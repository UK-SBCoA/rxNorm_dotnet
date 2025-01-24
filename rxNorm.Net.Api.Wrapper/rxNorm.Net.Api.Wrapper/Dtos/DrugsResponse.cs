using System;
using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class DrugsResponse
    {
        [JsonPropertyName("drugGroup")]
        public DrugsGroup Group { get; set; }
    }
}