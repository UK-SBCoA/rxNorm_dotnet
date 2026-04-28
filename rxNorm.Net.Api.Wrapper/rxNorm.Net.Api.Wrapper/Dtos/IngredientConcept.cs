using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class IngredientConcept
    {
        [JsonPropertyName("ingredientRxcui")]
        public string IngredientRxCUI { get; set; }

        [JsonPropertyName("ingredientName")]
        public string IngredientName { get; set; }
    }
}
