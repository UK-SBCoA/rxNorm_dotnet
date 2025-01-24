using System;
namespace rxNorm.Net.Api.Wrapper.Tests
{
    public class GetDrugsTests
    {
        private readonly HttpClient _httpClient;
        private readonly IRxNormClient _rxNormClient;

        public GetDrugsTests()
        {
            _httpClient = new HttpClient();
            _rxNormClient = new RxNormClient(_httpClient);
        }

        [Fact]
        public async void GetDrugs_WithName_FindsDrug()
        {
            var list = await _rxNormClient.GetDrugs("cymbalta");

            Assert.NotNull(list);

            Assert.NotEqual(0, list.Count()); // there should be results
        }

        [Fact]
        public async void GetDrugs_WithName_FindsDrugDeep()
        {
            var list = await _rxNormClient.GetDrugs("azithromycin");

            Assert.NotNull(list);

            Assert.NotEqual(0, list.Count()); // there should be results

            foreach (var group in list)
            {
                Assert.NotNull(group.TTY);

                // It is possible for some groups to not return results, but still have a TTY defined (ie. drug output type)
                if (group.List != null && group.List.Count() > 0)
                {
                    foreach (var drug in group.List)
                    {
                        // if there are results, must have an RxCUI
                        Assert.NotNull(drug.RxCUI);
                    }
                }
            }
        }
    }
}

