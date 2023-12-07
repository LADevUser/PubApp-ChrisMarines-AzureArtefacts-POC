using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class Machinery
    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]        
        public ReeferContainer reeferContainer {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public CargoCooling cargoCooling {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Heating_Discharge_Pump heating_Discharge_Pump {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Shore_Side_Electricitys shore_Side_Electricitys {get; set;}
    }
}