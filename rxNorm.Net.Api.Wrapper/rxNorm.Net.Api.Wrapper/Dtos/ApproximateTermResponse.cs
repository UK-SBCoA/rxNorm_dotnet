﻿using System;
using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    // JSON response https://rxnav.nlm.nih.gov/REST/approximateTerm.json?term=zocor%2010%20mg&maxEntries=4
    public class ApproximateTermResponse
    {
        [JsonPropertyName("approximateGroup")]
        public ApproximateTermCollection ApproximateGroup { get; set; }
    }
}

