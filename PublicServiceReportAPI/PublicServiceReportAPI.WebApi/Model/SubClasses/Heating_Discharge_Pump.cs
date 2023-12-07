using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class Heating_Discharge_Pump
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Discharge_Pump_Work {get;set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Discharge_Pump_SFOC {get;set;}

        [Required]
        [MaxLength(30)]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Discharge_Pump_Fuel_Type {get;set;}
    }
}