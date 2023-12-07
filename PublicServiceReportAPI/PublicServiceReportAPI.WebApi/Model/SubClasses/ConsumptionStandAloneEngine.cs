using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class ConsumptionStandAloneEngine
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal DPP_Cargo_Pump_Consumption_MDO {get;set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal DPP_Cargo_Pump_Consumption_O {get;set;}

        [Required]
        [MaxLength(30)]
        [JsonProperty(Required = Required.DisallowNull)]
        public string DPP_Cargo_Pump_Consumption_O_type {get;set;}
    }
}