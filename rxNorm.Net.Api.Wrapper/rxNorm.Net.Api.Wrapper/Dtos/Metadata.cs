using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class Metadata
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("releaseStartDate")]
        public string ReleaseStartDate { get; set; }

        [JsonPropertyName("releaseEndDate")]
        public string ReleaseEndDate { get; set; }

        [JsonPropertyName("isCurrent")]
        public string IsCurrent { get; set; }

        [JsonPropertyName("activeStartDate")]
        public string ActiveStartDate { get; set; }

        [JsonPropertyName("activeEndDate")]
        public string ActiveEndDate { get; set; }

        [JsonPropertyName("remappedDate")]
        public string RemappedDate { get; set; }
    }
}
