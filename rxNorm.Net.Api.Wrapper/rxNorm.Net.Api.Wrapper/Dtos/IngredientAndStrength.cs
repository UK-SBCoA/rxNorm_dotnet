using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class IngredientAndStrength
    {
        [JsonPropertyName("baseRxcui")]
        public string BaseRxCUI { get; set; }

        [JsonPropertyName("baseName")]
        public string BaseName { get; set; }

        [JsonPropertyName("bossRxcui")]
        public string BossRxCUI { get; set; }

        [JsonPropertyName("bossName")]
        public string BossName { get; set; }

        [JsonPropertyName("activeIngredientRxcui")]
        public string ActiveIngredientRxCUI { get; set; }

        [JsonPropertyName("activeIngredientName")]
        public string ActiveIngredientName { get; set; }

        [JsonPropertyName("moietyRxcui")]
        public string MoietyRxCUI { get; set; }

        [JsonPropertyName("moietyName")]
        public string MoietyName { get; set; }

        [JsonPropertyName("numeratorValue")]
        public string NumeratorValue { get; set; }

        [JsonPropertyName("numeratorUnit")]
        public string NumeratorUnit { get; set; }

        [JsonPropertyName("denominatorValue")]
        public string DenominatorValue { get; set; }

        [JsonPropertyName("denominatorUnit")]
        public string DenominatorUnit { get; set; }
    }

}
