using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class FuelTypeRemaings
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal HFO_ROB {get;set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal LFO_ROB {get;set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal MGO_ROB {get;set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal MDO_ROB {get;set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal LPGP_ROB {get;set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal LPGB_ROB {get;set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal LNG_ROB {get;set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Methanol_ROB {get;set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Ethanol_ROB {get;set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal O_ROB {get;set;}

        [Required]
        [MaxLength(30)]
        [JsonProperty(Required = Required.DisallowNull)]
        public string O_ROB_type {get;set;}
    }
}