using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class ConsumptionFuelBased
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public MainEnginesFuelBased mainengines {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public AUXEnginesFuelBased auxengines {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public BoilersFuelBased boilers {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public InertGasFuelBased inertgas {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public IncineratorsFuelBased incinerators {get; set;}

    }
}