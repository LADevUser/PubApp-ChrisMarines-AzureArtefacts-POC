using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class MainEngine2_4BDNBased 
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal ME_2_4_Consumption {get;set;}
    }
}