using System;
using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class ApproximateTermItem
    {
        [JsonPropertyName("rxcui")]
        public string RxCUI { get; set; }

        [JsonPropertyName("rxaui")]
        public string RxAUI { get; set; }

        [JsonPropertyName("score")]
        public decimal Score { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}

