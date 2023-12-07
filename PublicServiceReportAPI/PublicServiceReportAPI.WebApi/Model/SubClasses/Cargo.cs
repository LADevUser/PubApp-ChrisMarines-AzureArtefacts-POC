using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class Cargo
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Cargo_Mt {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Cargo_m3 {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public long Passengers {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public Containers containers {get; set;}
    }
}