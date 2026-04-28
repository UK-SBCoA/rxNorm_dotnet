using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class DoseFormGroupConcept
    {
        [JsonPropertyName("doseFormGroupRxcui")]
        public string DoseFormGroupRxCUI { get; set; }

        [JsonPropertyName("doseFormGroupName")]
        public string DoseFormGroupName { get; set; }
    }
}
