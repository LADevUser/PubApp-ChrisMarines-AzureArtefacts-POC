using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class Longitude
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public long Longitude_Degree {get; set;}
        
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Longitude_Minutes {get; set;}
        
        [Required]
        [MaxLength(5)]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Longitude_North_South {get; set;}
    }
}