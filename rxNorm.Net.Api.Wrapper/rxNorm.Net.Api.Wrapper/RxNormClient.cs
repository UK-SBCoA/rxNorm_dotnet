using System;
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
        /// <param name="name"></param>
        /// <param name="scopeOfSearch"></param>
        /// <param name="sourceLists"></param>
        /// <param name="precision"></param>
        /// <returns></returns>
        public async Task<string[]> FindRxCUIByStringAsync(string name, int? scopeOfSearch = null, string[] sourceLists = null, int? precision = null)
        {
            if (String.IsNullOrWhiteSpace(name))
                return new string[] { };

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
                Response responseDto = JsonSerializer.Deserialize<Response>(content);

                if (responseDto.IdGroup.RxCUIs != null)
                {
                    return responseDto.IdGroup.RxCUIs;
                }
                else
                    return new string[] { };
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return new string[] { };
            }

            throw new HttpRequestException($"Invalid status code in the HttpResponseMessage: {response.StatusCode}.");
        }

        public async Task<string[]> GetDisplayTermsAsync(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
                return new string[] { };

            string url = $"{_options.Host}/displaynames.json";

            var response = await _httpClient.GetAsync(url);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                Response responseDto = JsonSerializer.Deserialize<Response>(content);

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

    }
}