using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class Shore_Side_Electricitys
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Shore_Side_Electricity_Reception {get;set;}
    }
}