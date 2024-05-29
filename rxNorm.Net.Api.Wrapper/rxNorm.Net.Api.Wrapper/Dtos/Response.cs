using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class Response
    {
        [JsonPropertyName("idGroup")]
        public RxCUICollection IdGroup { get; set; }

        [JsonPropertyName("displayTermsList")]
        public DisplayTermsList DisplayTermsList { get; set; }

    }
}

