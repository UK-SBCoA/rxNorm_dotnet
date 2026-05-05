using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class Attributes
    {
        [JsonPropertyName("rxcui")]
        public string RxCUI { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("tty")]
        public string Tty { get; set; }

        [JsonPropertyName("isMultipleIngredient")]
        public string IsMultipleIngredient { get; set; }

        [JsonPropertyName("isBranded")]
        public string IsBranded { get; set; }
    }
}
