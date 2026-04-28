using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class DefinitionalFeatures
    {
        [JsonPropertyName("ingredientAndStrength")]
        public IngredientAndStrength[] IngredientAndStrength { get; set; }

        [JsonPropertyName("doseFormConcept")]
        public DoseFormConcept[] DoseFormConcept { get; set; }

        [JsonPropertyName("doseFormGroupConcept")]
        public DoseFormGroupConcept[] DoseFormGroupConcept { get; set; }
    }
}
