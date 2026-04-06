
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
    public async void RxNormIsCurrent_ReturnsTrue()
    {
        bool? result = await _rxNormClient.RxNormIsCurrentAsync("435");
        Assert.True(result);
    }
    [Fact]
    public async void RxNormIsCurrent_ReturnsFalse()
    {
        bool? result = await _rxNormClient.RxNormIsCurrentAsync("InvalidRxCUI"); //Invalid RxCUI, should return false
        Assert.False(result);
    }
    [Fact]
    public async void RxNormIsCurrent_ReturnsNull()
    {
        bool? result = await _rxNormClient.RxNormIsCurrentAsync("  "); //Whitespace input, should return null
        Assert.Null(result);
    }
    [Fact]
    public async void GetRxCUIs_CurrentScopeSearch_FindsMatch()
    {
        string rxCUI = await _rxNormClient.FindRxCUIByStringAsync("lidocaine hydrochloride 0.02 MG/MG", 1, null, null);

        Assert.NotNull(rxCUI);
        Assert.Equal("1011799", rxCUI);

    }

    [Fact]
    public async void GetRxCUIs_ForExactSearch_NoResult()
    {
        string rxCUI = await _rxNormClient.FindRxCUIByStringAsync("Advil 200 mg Tab");

        Assert.Empty(rxCUI);
    }

    [Fact]
    public async void GetRxCUIs_NormalizedSearch_FindsSimilarMatch()
    {
        string rxCUI = await _rxNormClient.FindRxCUIByStringAsync("Advil 200 mg Tab", null, null, 1);

        Assert.NotNull(rxCUI);
        Assert.Equal("153008", rxCUI);
    }
}
