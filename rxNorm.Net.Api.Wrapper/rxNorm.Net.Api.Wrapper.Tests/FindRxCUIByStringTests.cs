using Microsoft.AspNetCore.Hosting;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace rxNorm.Net.Api.Wrapper.Tests;

public class FindRxCUIByStringTests
{
    private readonly HttpClient _httpClient;
    private readonly IRxNormClient _rxNormClient;

    public FindRxCUIByStringTests()
    {
        _httpClient = new HttpClient();

        _rxNormClient = new RxNormClient(_httpClient);
    }

    [Fact]
    public async void GetRxCUIs_CurrentScopeSearch_FindsMatch()
    {
        string[] rxCUIs = await _rxNormClient.FindRxCUIByStringAsync("lidocaine hydrochloride 0.02 MG/MG", 1, null, null);

        Assert.Equal(1, rxCUIs.Length);
        Assert.Equal("1011799", rxCUIs[0]);

    }

    [Fact]
    public async void GetRxCUIs_ForExactSearch_NoResult()
    {
        string[] rxCUIs = await _rxNormClient.FindRxCUIByStringAsync("Advil 200 mg Tab");

        Assert.Equal(0, rxCUIs.Length);
    }

    [Fact]
    public async void GetRxCUIs_NormalizedSearch_FindsSimilarMatch()
    {
        string[] rxCUIs = await _rxNormClient.FindRxCUIByStringAsync("Advil 200 mg Tab", null, null, 1);

        Assert.Equal(1, rxCUIs.Length);
        Assert.Equal("153008", rxCUIs[0]);
    }
}
