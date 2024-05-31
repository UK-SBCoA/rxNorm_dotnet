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

            string firtTerm = terms[0];
            
        }

        [Fact]
        public async void GetDisplayTerms_FindIbuprofen_FindsTerms()
        {
            string[] terms = await _rxNormClient.GetDisplayTermsAsync();

            bool ibuprofenExist = terms.Contains("Ibuprofen");


            Assert.True(ibuprofenExist);
        }
	}
}

