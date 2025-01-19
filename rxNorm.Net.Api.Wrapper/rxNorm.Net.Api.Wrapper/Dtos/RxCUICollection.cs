using System;
using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class RxCUICollection
    {
        [JsonPropertyName("rxnormId")]
        public string[] RxNormId { get; set; }
    }
}

