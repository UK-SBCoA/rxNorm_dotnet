using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class DoseFormConcept
    {
        [JsonPropertyName("doseFormRxcui")]
        public string DoseFormRxCUI { get; set; }

        [JsonPropertyName("doseFormName")]
        public string DoseFormName { get; set; }
    }
}
