using System;
namespace rxNorm.Net.Api.Wrapper.Tests
{
    public class GetDisplayTermsTests
    {
        private readonly HttpClient _httpClient;
        private readonly IRxNormClient _rxNormClient;

        public GetDisplayTermsTests()
        {
            _httpClient = new HttpClient();

            _rxNormClient = new RxNormClient(_httpClient);
        }

        [Fact]
        public async void GetDisplayTerms_GetsTerms()
        {
            string[] terms = await _rxNormClient.GetDisplayTermsAsync();

            Assert.NotEmpty(terms);

            string firstTerm = terms[0];

            Assert.NotNull(firstTerm);
        }

        [Fact]
        public async Task CountDisplayTermsAsync_FindIbuprofen_GetsCount()
        {
            int count = await _rxNormClient.CountDisplayTermsAsync("ibuprofen");

            Assert.Equal(30, count); // As of 2024-06-06 there are 30 entries that contain ibuprofen, this will change and the assertion will need to be updated

        }

        [Fact]
        public async Task SearchDisplayTermsAsync_FindIbuprofen_FindsTerms()
        {
            int pageSize = 5;

            var terms = await _rxNormClient.SearchDisplayTermsAsync("ibuprofen", pageSize, 1);

            bool ibuprofenExist = terms.Any(term => term.Contains("ibuprofen", StringComparison.OrdinalIgnoreCase));

            Assert.True(ibuprofenExist);

            int count = terms.Where(term => term.Contains("ibuprofen", StringComparison.OrdinalIgnoreCase)).Count();

            Assert.True(count <= pageSize);
        }

        [Fact]
        public async Task SearchDisplayTermsAsync_FindIbuprofen_CanPaginate()
        {
            int pageSize = 5;
            int totalTerms = await _rxNormClient.CountDisplayTermsAsync("ibuprofen");

            if (totalTerms > 0)
            {
                int totalPages = (int)Math.Ceiling((double)totalTerms / pageSize);
                for (int page = 1; page <= totalPages; page++)
                {
                    var terms = await _rxNormClient.SearchDisplayTermsAsync("ibuprofen", pageSize, page);
                    Assert.NotEmpty(terms);
                }
            }
        }
    }
}

