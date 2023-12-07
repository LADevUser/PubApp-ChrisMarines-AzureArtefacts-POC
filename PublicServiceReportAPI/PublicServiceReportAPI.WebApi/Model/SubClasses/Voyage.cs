using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class Voyage
    {
        [MaxLength(5)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Voyage_From { get; set; }

        [MaxLength(5)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Voyage_To { get; set; }

        [MaxLength(30)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Voyage_Type { get; set; }

        [MaxLength(30)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Voyage_Number { get; set; }

        [MaxLength(100)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Offhire_Reasons { get; set; }
    }
}