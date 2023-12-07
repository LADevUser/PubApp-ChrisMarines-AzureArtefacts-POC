using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class BoilersBDNBased
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Boiler_Consumption {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Boiler_Consumption_BDN_2 {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Boiler_Consumption_BDN_3 {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Boiler_Consumption_BDN_4 {get;set;}
    }
}