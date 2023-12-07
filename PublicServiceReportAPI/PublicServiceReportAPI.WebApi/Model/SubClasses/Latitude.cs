using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class Latitude
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public long Latitude_Degree {get; set;}
        
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Latitude_Minutes {get; set;}
        
        [Required]
        [MaxLength(5)]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Latitude_North_South {get; set;}
    }
}