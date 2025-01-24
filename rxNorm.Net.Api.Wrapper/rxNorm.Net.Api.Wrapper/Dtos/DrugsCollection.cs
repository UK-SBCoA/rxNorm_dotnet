using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace rxNorm.Net.Api.Wrapper.Dtos
{
    public class DrugsCollection
    {
        [JsonPropertyName("tty")]
        public string TTY { get; set; }

        [JsonPropertyName("conceptProperties")]
        public DrugsItem[] List { get; set; }
    }
}

