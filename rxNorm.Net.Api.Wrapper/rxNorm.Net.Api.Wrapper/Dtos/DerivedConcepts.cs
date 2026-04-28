using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class DerivedConcepts
    {
        [JsonPropertyName("ingredientConcept")]
        public IngredientConcept[] IngredientConcept { get; set; }

        [JsonPropertyName("quantifiedConcept")]
        public QuantifiedConcept[] QuantifiedConcept { get; set; }
    }
}
