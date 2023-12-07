using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class AuxEngine1BDNBased
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal AE_1_Consumption {get;set;}
    }
}