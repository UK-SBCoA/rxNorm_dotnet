using System;
using System.ComponentModel;

namespace rxNorm.Net.Api.Wrapper.Enums
{
    public enum DrugOutputType
    {
        [Description("Clinical drug")]
        SCD,
        [Description("Clinical pack")]
        GPCK,
        [Description("Branded drug")]
        SBD,
        [Description("Branded pack")]
        BPCK
    }
}

