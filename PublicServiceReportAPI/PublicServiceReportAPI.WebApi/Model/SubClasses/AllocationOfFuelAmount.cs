using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class AllocationOfFuelAmount
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public CargoHeating cargoHeating {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ConsumptionStandAloneEngine consumptionStandAloneEngine {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ConsumptionWhileInDP consumptionWhileInDP {get;set;}

    }
}