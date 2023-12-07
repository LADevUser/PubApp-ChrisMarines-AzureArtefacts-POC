using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class Boiler1BDNBased
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Boiler_1_Consumption {get;set;}
    }
}