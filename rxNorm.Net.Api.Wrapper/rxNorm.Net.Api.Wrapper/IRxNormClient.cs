using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using rxNorm.Net.Api.Wrapper.Models;

namespace rxNorm.Net.Api.Wrapper
{
    public interface IRxNormClient
    {
        Task<string> FindRxCUIByStringAsync(string name, int? scopeOfSearch = null, string[] sourceLists = null, int? precision = null);

        Task<string[]> GetDisplayTermsAsync();
        Task<int> CountDisplayTermsAsync(string searchString);
        Task<string[]> SearchDisplayTermsAsync(string searchString, int pageSize = 10, int pageIndex = 1);

        Task<List<ApproximateMatch>> GetApproximateMatches(string searchString, int pageSize = 20);
    }
}

