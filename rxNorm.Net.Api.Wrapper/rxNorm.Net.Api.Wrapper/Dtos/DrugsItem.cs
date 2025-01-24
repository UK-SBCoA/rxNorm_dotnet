using System;
using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class DrugsItem
    {
        [JsonPropertyName("rxcui")]
        public string? RxCUI { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("synonym")]
        public string? Synonym { get; set; }

        [JsonPropertyName("tty")]
        public string? TTY { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("suppress")]
        public string? Suppress { get; set; }

        [JsonPropertyName("umlscui")]
        public string? UmlsCUI { get; set; }
    }
}

