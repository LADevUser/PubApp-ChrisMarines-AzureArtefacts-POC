using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class GasCombustionUnitsBDNBased
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? GCU_Consumption {get;set;}
    }
}