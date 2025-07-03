using System;
namespace rxNorm.Net.Api.Wrapper
{
    public class RxNormClientOptions
    {
        /// <summary>
        /// Base URL
        /// </summary>
        public string Host { get; private set; }

        /// <summary>
        /// Indicates whether an HTTP error response should be raised as an exception
        /// </summary>
        public bool HttpErrorAsException { get; set; } = false;

        public RxNormClientOptions()
        {
            Host = "https://rxnav.nlm.nih.gov/REST";
        }
    }
}

