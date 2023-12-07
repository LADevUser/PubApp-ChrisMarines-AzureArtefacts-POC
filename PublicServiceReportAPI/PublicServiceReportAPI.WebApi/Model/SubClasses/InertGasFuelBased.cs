using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class InertGasFuelBased
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Inert_gas_Consumption_HFO {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Inert_gas_Consumption_LFO {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Inert_gas_Consumption_MGO {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Inert_gas_Consumption_MDO {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Inert_gas_Consumption_LPGP {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Inert_gas_Consumption_LPGB {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Inert_gas_Consumption_LNG {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Inert_gas_Consumption_M {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Inert_gas_Consumption_E {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Inert_gas_Consumption_O {get; set;}

        [Required]
        [MaxLength(30)]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Inert_gas_Consumption_O_type {get; set;}
    }
    
}