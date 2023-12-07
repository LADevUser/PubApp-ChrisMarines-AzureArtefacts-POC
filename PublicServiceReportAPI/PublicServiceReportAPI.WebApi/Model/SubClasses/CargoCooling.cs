using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class CargoCooling
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Cargo_Cooling_Work {get;set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Cargo_Cooling_SFOC {get;set;}

        [Required]
        [MaxLength(30)]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Cargo_Cooling_Fuel_Type {get;set;}
    }
}
