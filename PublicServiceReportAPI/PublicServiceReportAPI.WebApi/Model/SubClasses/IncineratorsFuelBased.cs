using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class IncineratorsFuelBased
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Incinerator_Consumption_O {get; set;}

        [Required]
        [MaxLength(30)]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Incinerator_Consumption_O_type {get; set;}
    }
    
}