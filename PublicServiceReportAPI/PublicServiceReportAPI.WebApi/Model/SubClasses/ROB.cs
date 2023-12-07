using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class ROB 
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FuelTypeRemaings fuelTypeRemaings {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public BDNBasedRemaings bDNBasedRemaings {get;set;}
    }
}