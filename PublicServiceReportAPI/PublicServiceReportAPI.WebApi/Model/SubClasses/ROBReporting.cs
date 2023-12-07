using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class ROBReporting
    {
        [Required]
        [MaxLength(30)]
        [JsonProperty(Required = Required.DisallowNull)]
        public string ROB_Fuel_BDN {get;set;}

        [MaxLength(30)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ROB_Fuel_BDN_2 {get;set;}

        [MaxLength(30)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ROB_Fuel_BDN_3 {get;set;}

        [MaxLength(30)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ROB_Fuel_BDN_4 {get;set;}

        [MaxLength(30)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ROB_Fuel_BDN_5 {get;set;}

        [MaxLength(30)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ROB_Fuel_BDN_6 {get;set;}

        [MaxLength(30)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ROB_Fuel_BDN_7 {get;set;}

        [MaxLength(30)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ROB_Fuel_BDN_8 {get;set;}
    }
}