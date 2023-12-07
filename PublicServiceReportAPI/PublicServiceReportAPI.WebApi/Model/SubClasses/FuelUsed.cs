using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class FuelUsed
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public MainEnginesFuelUsed mainEnginesFuelUsed {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AuxEnginesAndBoilers auxEnginesAndBoilers {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ROBReporting robReporting {get;set;}
    }
}