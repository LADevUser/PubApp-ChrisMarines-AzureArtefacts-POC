using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System;

namespace PublicServiceReportAPI.WebApi.Model.Public
{
    public class ReportingServiceInformation
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public long IMO { get; set; }

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Date_UTC { get; set; }

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Time_UTC { get; set; }

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

        [MaxLength(30)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Event { get; set; }
    }
}