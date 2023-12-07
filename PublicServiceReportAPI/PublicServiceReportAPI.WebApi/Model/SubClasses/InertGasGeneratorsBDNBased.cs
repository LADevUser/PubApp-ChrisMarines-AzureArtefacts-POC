using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class InertGasGeneratorsBDNBased
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? IGG_Consumption {get;set;}
    }
}