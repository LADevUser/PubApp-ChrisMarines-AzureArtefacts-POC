using System;

namespace PublicServiceReportAPI.WebApi.Model.Canonical
{
    public class CanonicalBunkerReportingInformation
    {
        public string BDN_Number { get; set; }   
        public string Bunker_Delivery_Date { get; set; }  
        public string Bunker_Delivery_Time { get; set; }
        public long IMO { get; set; }
        public string Fuel_Type { get; set; }
        public decimal? Mass { get; set; }
        public decimal? Density_At_15dg { get; set; }
        public decimal? Sulphur_Content { get; set; }
        public decimal? Viscosity { get; set; }
        public decimal? Water_Content { get; set; }
        public decimal? Higher_Heating_Value { get; set; }
        public decimal? Lower_Heating_Value { get; set; }
        public string Grade { get; set; }
        public string Bunker_Port { get; set; }
        public decimal? TtW_CO2_CF { get; set; }
        public DateTime reportingdate { get; set; }
        public string MessageType { get; set; }
    }

}