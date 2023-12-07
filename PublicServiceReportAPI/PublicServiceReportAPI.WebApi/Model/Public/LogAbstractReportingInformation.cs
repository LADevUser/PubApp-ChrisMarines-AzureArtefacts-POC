using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using PublicServiceReportAPI.WebApi.Model.Subclasses;
using PublicServiceReportAPI.WebApi.Model.Enums;
using System;
using Microsoft.AspNetCore.CookiePolicy;

namespace PublicServiceReportAPI.WebApi.Model.Public
{
    public class LogAbstractReportingInformation
    {
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public long IMO { get; set; }

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Date_UTC { get; set; }

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Time_UTC { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Voyage voayge { get; set; }

        [MaxLength(30)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Event { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TimeElapsed time_elapsed  { get; set; }

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public decimal Distance  { get; set; }

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public Position position  { get; set; }

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public Cargo cargo  { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ConsumptionFuelBased consumptionfuelbased { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ConsumptionBDNBased consumptionBDNbased { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public ROB rob { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public FuelUsed fuelused { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public AllocationOfFuelAmount allocationoffuelamount { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Machinery machinery {get; set;}

    }
}