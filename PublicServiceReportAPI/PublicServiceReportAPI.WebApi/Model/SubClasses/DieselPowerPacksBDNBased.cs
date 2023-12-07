using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class DieselPowerPacksBDNBased
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? DPP_Consumption {get;set;}
    }
}