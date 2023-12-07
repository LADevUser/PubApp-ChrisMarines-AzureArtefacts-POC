using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class AuxEnginesBDNBased
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal AE_Consumption {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AE_Consumption_BDN_2 {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AE_Consumption_BDN_3 {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? AE_Consumption_BDN_4 {get;set;}
    }
}