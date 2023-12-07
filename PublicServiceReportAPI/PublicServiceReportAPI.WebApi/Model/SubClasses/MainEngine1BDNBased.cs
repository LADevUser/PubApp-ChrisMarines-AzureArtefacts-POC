using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class MainEngine1BDNBased 
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal ME_1_Consumption {get;set;}
    }
}