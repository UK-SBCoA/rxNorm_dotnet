using System;
using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class ApproximateTermItem
    {
        [JsonPropertyName("rxcui")]
        public string RxCUI { get; set; }

        [JsonPropertyName("rxaui")]
        public string? RxAUI { get; set; }

        [JsonPropertyName("score")]
        public string? Score { get; set; }

        [JsonPropertyName("rank")]
        public string? Rank { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("source")]
        public string? Source { get; set; }
    }
}

