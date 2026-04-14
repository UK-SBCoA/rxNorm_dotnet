using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{

    public class RxcuiHistoryStatusResponse
    {
        [JsonPropertyName("rxcuiStatusHistory")]
        public Rxcuistatushistory RxcuiStatusHistory { get; set; }
    }

    public class Rxcuistatushistory
    {
        [JsonPropertyName("metaData")]
        public Metadata MetaData { get; set; }

        [JsonPropertyName("attributes")]
        public Attributes Attributes { get; set; }

        [JsonPropertyName("definitionalFeatures")]
        public Definitionalfeatures DefinitionalFeatures { get; set; }

        [JsonPropertyName("pack")]
        public Pack Pack { get; set; }

        [JsonPropertyName("derivedConcepts")]
        public Derivedconcepts DerivedConcepts { get; set; }
    }

    public class Metadata
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("releaseStartDate")]
        public string ReleaseStartDate { get; set; }

        [JsonPropertyName("releaseEndDate")]
        public string ReleaseEndDate { get; set; }

        [JsonPropertyName("isCurrent")]
        public string IsCurrent { get; set; }

        [JsonPropertyName("activeStartDate")]
        public string ActiveStartDate { get; set; }

        [JsonPropertyName("activeEndDate")]
        public string ActiveEndDate { get; set; }

        [JsonPropertyName("remappedDate")]
        public string RemappedDate { get; set; }
    }

    public class Attributes
    {
        [JsonPropertyName("rxcui")]
        public string Rxcui { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("tty")]
        public string Tty { get; set; }

        [JsonPropertyName("isMultipleIngredient")]
        public string IsMultipleIngredient { get; set; }

        [JsonPropertyName("isBranded")]
        public string IsBranded { get; set; }
    }

    public class Definitionalfeatures
    {
        [JsonPropertyName("ingredientAndStrength")]
        public Ingredientandstrength[] IngredientAndStrength { get; set; }

        [JsonPropertyName("doseFormConcept")]
        public Doseformconcept[] DoseFormConcept { get; set; }

        [JsonPropertyName("doseFormGroupConcept")]
        public Doseformgroupconcept[] DoseFormGroupConcept { get; set; }
    }

    public class Ingredientandstrength
    {
        [JsonPropertyName("baseRxcui")]
        public string BaseRxcui { get; set; }

        [JsonPropertyName("baseName")]
        public string BaseName { get; set; }

        [JsonPropertyName("bossRxcui")]
        public string BossRxcui { get; set; }

        [JsonPropertyName("bossName")]
        public string BossName { get; set; }

        [JsonPropertyName("activeIngredientRxcui")]
        public string ActiveIngredientRxcui { get; set; }

        [JsonPropertyName("activeIngredientName")]
        public string ActiveIngredientName { get; set; }

        [JsonPropertyName("moietyRxcui")]
        public string MoietyRxcui { get; set; }

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

    public class Doseformconcept
    {
        [JsonPropertyName("doseFormRxcui")]
        public string DoseFormRxcui { get; set; }

        [JsonPropertyName("doseFormName")]
        public string DoseFormName { get; set; }
    }

    public class Doseformgroupconcept
    {
        [JsonPropertyName("doseFormGroupRxcui")]
        public string DoseFormGroupRxcui { get; set; }

        [JsonPropertyName("doseFormGroupName")]
        public string DoseFormGroupName { get; set; }
    }

    public class Pack
    {
    }

    public class Derivedconcepts
    {
        [JsonPropertyName("ingredientConcept")]
        public Ingredientconcept[] IngredientConcept { get; set; }

        [JsonPropertyName("quantifiedConcept")]
        public Quantifiedconcept[] QuantifiedConcept { get; set; }
    }

    public class Ingredientconcept
    {
        [JsonPropertyName("ingredientRxcui")]
        public string IngredientRxcui { get; set; }

        [JsonPropertyName("ingredientName")]
        public string IngredientName { get; set; }
    }

    public class Quantifiedconcept
    {
        [JsonPropertyName("quantifiedRxcui")]
        public string QuantifiedRxcui { get; set; }

        [JsonPropertyName("quantifiedName")]
        public string QuantifiedName { get; set; }

        [JsonPropertyName("quantifiedTTY")]
        public string QuantifiedTTY { get; set; }

        [JsonPropertyName("quantifiedActive")]
        public string QuantifiedActive { get; set; }
    }

}
