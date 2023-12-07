using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System;

namespace PublicServiceReportAPI.WebApi.Model.Public
{
    public class BunkerReportIngInformation
    {
        [Required]
        [MaxLength(30)]
        [JsonProperty(Required = Required.DisallowNull)]
        public string BDN_Number { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Bunker_Delivery_Date { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Bunker_Delivery_Time { get; set; }

        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public long IMO { get; set; }

        [Required]
        [MaxLength(10)]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Fuel_Type { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Mass { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Density_At_15dg { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Sulphur_Content { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Viscosity { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Water_Content { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Higher_Heating_Value { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Lower_Heating_Value { get; set; }

        [MaxLength(10)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Grade { get; set; }

        [MaxLength(5)]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Bunker_Port { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? TtW_CO2_CF { get; set; }

    }
}