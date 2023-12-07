using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class TimeElapsed
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Time_Since_Previous_Report { get; set; }
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Time_Elapsed_Sailing { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Time_Elapsed_Anchoring { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Time_Elapsed_DP { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Time_Elapsed_Ice { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Time_Elapsed_Maneuvering { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Time_Elapsed_Waiting { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Time_Elapsed_Loading_Unloading { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Time_Elapsed_Drifting { get; set; }
    }
}