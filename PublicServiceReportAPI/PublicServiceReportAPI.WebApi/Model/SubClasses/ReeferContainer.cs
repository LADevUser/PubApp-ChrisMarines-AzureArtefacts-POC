using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class ReeferContainer
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Reefer_Work {get;set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Reefer_SFOC {get;set;}

        [Required]
        [MaxLength(30)]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Reefer_Fuel_Type {get;set;}
    }
}