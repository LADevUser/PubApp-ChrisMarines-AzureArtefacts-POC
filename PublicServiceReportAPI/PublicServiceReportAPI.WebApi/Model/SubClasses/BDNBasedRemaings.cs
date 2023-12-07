using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class BDNBasedRemaings
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal BDN_ROB {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BDN_2_ROB {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BDN_3_ROB {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BDN_4_ROB {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BDN_5_ROB {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BDN_6_ROB {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BDN_7_ROB {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? BDN_8_ROB {get;set;}
    }
}