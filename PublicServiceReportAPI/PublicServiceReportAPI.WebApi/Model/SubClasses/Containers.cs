using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class Containers
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public long Reefer_20_Chilled {get; set;}
        
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public long Reefer_40_Chilled {get; set;}

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public long Reefer_20_Frozen {get; set;}
        
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public long Reefer_40_Frozen {get; set;}
    }
}