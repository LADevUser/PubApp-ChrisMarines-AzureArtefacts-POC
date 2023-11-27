
using System.ComponentModel.DataAnnotations;
using System;

namespace PublicServiceReportAPI.WebApi.Model.Canonical
{
    public class CanonicalReportingServiceInformation
    {
        public long IMO { get; set; }
        public string Date_UTC { get; set; }
        public string Time_UTC { get; set; }
        public string Voyage_From { get; set; }
        public string Voyage_To { get; set; }
        public string Voyage_Type { get; set; }
        public string Voyage_Number { get; set; }
        public string Offhire_Reasons { get; set; }
        public string Event { get; set; }
        public string shipid { get; set; }
        public DateTime reportingdate { get; set; }
        public string MessageType { get; set; }
    }
}