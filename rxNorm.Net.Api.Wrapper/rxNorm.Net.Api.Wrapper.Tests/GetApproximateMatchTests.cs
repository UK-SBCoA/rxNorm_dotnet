using System;
namespace rxNorm.Net.Api.Wrapper.Tests
{
    public class GetApproximateMatchTests
    {
        private readonly HttpClient _httpClient;
        private readonly IRxNormClient _rxNormClient;

        public GetApproximateMatchTests()
        {
            _httpClient = new HttpClient();

            _rxNormClient = new RxNormClient(_httpClient);
        }

        [Fact]
        public async void GetApproximateMatch_ForGoodSearch_HasResult()
        {
            var matches = await _rxNormClient.GetApproximateMatches("zocor");

            Assert.NotNull(matches);

            foreach (var match in matches)
            {
                Assert.NotNull(match.Name);
            }
        }
    }
}

