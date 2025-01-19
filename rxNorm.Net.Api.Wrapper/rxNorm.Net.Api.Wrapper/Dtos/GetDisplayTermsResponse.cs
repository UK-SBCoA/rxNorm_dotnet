using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class GetDisplayTermsResponse
    {
        [JsonPropertyName("displayTermsList")]
        public DisplayTermsList DisplayTermsList { get; set; }

    }
}

