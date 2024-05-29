using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class DisplayTermsList
    {
        [JsonPropertyName("term")]
        public List<string> Term { get; set; }
    }
}