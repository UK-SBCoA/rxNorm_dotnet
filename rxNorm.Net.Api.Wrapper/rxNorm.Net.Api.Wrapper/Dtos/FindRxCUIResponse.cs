using System;
using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class FindRxCUIResponse
    {
        [JsonPropertyName("idGroup")]
        public RxCUICollection IdGroup { get; set; }
    }
}

