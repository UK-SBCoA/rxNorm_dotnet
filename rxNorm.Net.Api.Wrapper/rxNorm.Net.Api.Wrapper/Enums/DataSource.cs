using System;
using System.ComponentModel;

namespace rxNorm.Net.Api.Wrapper.Enums
{
    public enum DataSource
    {
        [Description("Gold Standard Drug Database")]
		GS,
        [Obsolete("Medi-Span Master Drug Data Base has been removed from the RxNorm data until further notice starting with the October 2017 release.")]
        [Description("Medi-Span Master Drug Data Base")]
        MDDB,
        [Description("Multum MediSource Lexicon")]
        MMSL,
        MMX,
        MSH,
        MTHFDA,
        MTHSPL,
        NDDF,
        NDFRT,
        RXNORM,
        SNOMEDCT,
        VANDF
    }
}

