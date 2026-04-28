using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class RxCUIHistoryStatusResponse
    {
        [JsonPropertyName("rxcuiStatusHistory")]
        public RxCUIStatusHistory RxCUIStatusHistory { get; set; }
    }
}
