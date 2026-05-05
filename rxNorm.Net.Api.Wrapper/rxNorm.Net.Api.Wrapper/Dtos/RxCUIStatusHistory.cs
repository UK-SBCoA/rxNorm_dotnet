using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class RxCUIStatusHistory
    {
        [JsonPropertyName("metaData")]
        public Metadata MetaData { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }

        [JsonPropertyName("definitionalFeatures")]
        public DefinitionalFeatures DefinitionalFeatures { get; set; }

        [JsonPropertyName("derivedConcepts")]
        public DerivedConcepts DerivedConcepts { get; set; }
    }
}
