using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using rxNorm.Net.Api.Wrapper.Dtos;

namespace rxNorm.Net.Api.Wrapper
{
    public class RxNormClient : IRxNormClient
    {
        private readonly RxNormClientOptions _options = new RxNormClientOptions();

        private readonly HttpClient _httpClient;

        public RxNormClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public RxNormClient(HttpClient httpClient, RxNormClientOptions options) : this(httpClient)
        {
            //_options = options ?? throw new ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// https://lhncbc.nlm.nih.gov/RxNav/APIs/api-RxNorm.findRxcuiByString.html
        /// </summary>
        /// <param name="name">The name parameter must completely match a string from an RxNorm vocabulary</param>
        /// <param name="scopeOfSearch"></param>
        /// <param name="sourceLists"></param>
        /// <param name="precision">0 or 1 or 2</param>
        /// <returns></returns>
        public async Task<string> FindRxCUIByStringAsync(string name, int? scopeOfSearch = null, string[] sourceLists = null, int? precision = null)
        {
            if (String.IsNullOrWhiteSpace(name))
                return "";

            string url = $"{_options.Host}/rxcui.json?name={WebUtility.UrlEncode(name)}";

            if (scopeOfSearch.HasValue)
                url += $"&allsrc={scopeOfSearch.Value}";

            if (sourceLists != null && sourceLists.Length > 0)
                url += $"&srclist={String.Join(" ", sourceLists)}";

            if (precision.HasValue)
                url += $"&search={precision.Value}";

            var response = await _httpClient.GetAsync(url);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                FindRxCUIResponse responseDto = JsonSerializer.Deserialize<FindRxCUIResponse>(content);

                // Only one RxCUI should be returned if an exact match was found (even though an json array is used)
                if (responseDto.IdGroup.RxNormId != null && responseDto.IdGroup.RxNormId.Length == 1)
                {
                    return responseDto.IdGroup.RxNormId.First();
                }
                else
                    return "";
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return "";
            }

            throw new HttpRequestException($"Invalid status code in the HttpResponseMessage: {response.StatusCode}.");
        }

        public async Task<string[]> GetDisplayTermsAsync()
        {
            string url = $"{_options.Host}/displaynames.json";

            var response = await _httpClient.GetAsync(url);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                GetDisplayTermsResponse responseDto = JsonSerializer.Deserialize<GetDisplayTermsResponse>(content);

                if (responseDto.DisplayTermsList.Term != null)
                {
                    return responseDto.DisplayTermsList.Term.ToArray();
                }
                else
                {
                    return new string[] { };
                }
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return new string[] { };
            }

            throw new HttpRequestException($"Invalid status code in the HttpResponseMessage: {response.StatusCode}.");
        }

        public async Task<int> CountDisplayTermsAsync(string searchString)
        {
            int count = 0;

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                var allTerms = await GetDisplayTermsAsync();

                if (allTerms != null)
                {
                    count = allTerms
                        .Where(term => term.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                        .Count();
                }
            }

            return count;
        }

        public async Task<string[]> SearchDisplayTermsAsync(string searchString, int pageSize = 10, int pageIndex = 1)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return Array.Empty<string>();

            var allTerms = await GetDisplayTermsAsync();

            var filteredTermsAndPaginated = allTerms
                .Where(term => term.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToArray();

            return filteredTermsAndPaginated;
        }

        /// <summary>
        /// https://lhncbc.nlm.nih.gov/RxNav/APIs/api-RxNorm.getApproximateMatch.html
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<List<ApproximateTermItem>> GetApproximateMatches(string searchString, bool includeNullNames = false, int pageSize = 20)
        {
            List<ApproximateTermItem> matches = new List<ApproximateTermItem>();

            if (String.IsNullOrWhiteSpace(searchString))
                return matches;

            string url = $"{_options.Host}/approximateTerm.json?term={WebUtility.UrlEncode(searchString)}";

            if (pageSize != 20)
                url += $"&maxEntries={pageSize}";

            var response = await _httpClient.GetAsync(url);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                ApproximateTermResponse responseDto = JsonSerializer.Deserialize<ApproximateTermResponse>(content);

                // Only one RxCUI should be returned if an exact match was found (even though an json array is used)
                if (responseDto.ApproximateGroup != null && responseDto.ApproximateGroup.Candidate != null)
                {
                    if (includeNullNames)
                        return responseDto.ApproximateGroup.Candidate.ToList();
                    else
                        return responseDto.ApproximateGroup.Candidate.Where(m => String.IsNullOrWhiteSpace(m.Name) == false).ToList();
                }
                else
                    return matches;
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return matches;
            }

            throw new HttpRequestException($"Invalid status code in the HttpResponseMessage: {response.StatusCode}.");
        }
    }
}