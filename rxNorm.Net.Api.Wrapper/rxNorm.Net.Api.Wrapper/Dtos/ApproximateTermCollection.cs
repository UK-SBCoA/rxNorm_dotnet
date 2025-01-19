using System;
using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class ApproximateTermCollection
    {
        [JsonPropertyName("inputTerm")]
        public string? InputTerm { get; set; }

        [JsonPropertyName("candidate")]
        public ApproximateTermItem[] Candidate { get; set; }
    }
}

