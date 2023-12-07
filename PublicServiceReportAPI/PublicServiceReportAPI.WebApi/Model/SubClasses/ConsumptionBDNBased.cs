using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class ConsumptionBDNBased
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public MainEnginesBDNBased mainEngines {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public MainEngine1BDNBased MainEngine1 {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public MainEngine2_4BDNBased mainEngine2_4 {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AuxEnginesBDNBased auxEngines {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AuxEngine1BDNBased auxEngine1 {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AuxEngine2_6BDNBased auxEngine2_6 {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public BoilersBDNBased boilers {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Boiler1BDNBased boiler1 {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Boiler2_4BDNBased boiler2_4 {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public InertGasGeneratorsBDNBased inertGasGenerators {get;set;} 

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public GasCombustionUnitsBDNBased gasCombustionUnits {get;set;}

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DieselPowerPacksBDNBased dieselPowerPacks {get;set;}
    }
}