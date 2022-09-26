using System;

namespace rxNorm.Net.Api.Wrapper.Enums
{
    // Bidirectional relationships that connect concepts together
    // Reference: https://www.nlm.nih.gov/research/umls/rxnorm/docs/appendix1.html
    // Relationships by term type: https://www.nlm.nih.gov/research/umls/rxnorm/docs/appendix1.html
    public enum Relationship
    {
        consists_of,
        constitutes,
        contained_in,
        contains,
        dose_form_of,
        form_of,
        has_dose_form,
        has_form,
        has_ingredient,
        has_ingredients,
        has_part,
        has_precise_ingredient,
        has_quantified_form,
        has_tradename,
        ingredient_of,
        ingredients_of,
        inverse_isa,
        isa,
        part_of,
        precise_ingredient_of,
        quantified_form_of,
        reformulated_to,
        reformulation_of,
        tradename_of
    }
}

