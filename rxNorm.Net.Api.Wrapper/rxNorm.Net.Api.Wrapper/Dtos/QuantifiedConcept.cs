using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class QuantifiedConcept
    {
        [JsonPropertyName("quantifiedRxcui")]
        public string QuantifiedRxCUI { get; set; }

        [JsonPropertyName("quantifiedName")]
        public string QuantifiedName { get; set; }

        [JsonPropertyName("quantifiedTTY")]
        public string QuantifiedTTY { get; set; }

        [JsonPropertyName("quantifiedActive")]
        public string QuantiFiedActive { get; set; }
    }
}
