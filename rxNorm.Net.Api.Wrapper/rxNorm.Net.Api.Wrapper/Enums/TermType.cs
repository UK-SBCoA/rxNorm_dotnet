using System;
using System.ComponentModel;

namespace rxNorm.Net.Api.Wrapper.Enums
{
    // Indicates generic and branded drug names at different levels of specificity
    // Reference: https://www.nlm.nih.gov/research/umls/rxnorm/docs/appendix5.html
    public enum TermType
    {
        [Description("Ingredient")]
        IN,
        [Description("Precise Ingredient")]
        PIN,
        [Description("Multiple Ingredients")]
        MIN
    }
}

