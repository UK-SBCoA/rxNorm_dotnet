using System;
using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class DrugsGroup
    {
        // RxNorm docs says "always empty"
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("conceptGroup")]
        public DrugsCollection[] Results { get; set; }

    }
}

