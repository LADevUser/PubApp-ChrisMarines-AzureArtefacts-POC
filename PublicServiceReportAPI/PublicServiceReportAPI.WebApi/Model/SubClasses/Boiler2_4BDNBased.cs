using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class Boiler2_4BDNBased
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal Boiler_2_4_Consumption {get;set;}
    }
}