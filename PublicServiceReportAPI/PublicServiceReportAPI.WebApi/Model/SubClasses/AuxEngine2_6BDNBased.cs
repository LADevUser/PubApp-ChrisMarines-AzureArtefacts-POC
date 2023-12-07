using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class AuxEngine2_6BDNBased
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal AE_2_6_Consumption {get;set;}
    }
}