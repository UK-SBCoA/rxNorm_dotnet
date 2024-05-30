using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace rxNorm.Net.Api.Wrapper
{
    public interface IRxNormClient
    {
        Task<string[]> FindRxCUIByStringAsync(string name, int? scopeOfSearch = null, string[] sourceLists = null, int? precision = null);
        Task<string[]> GetDisplayTermsAsync();
    }
}

