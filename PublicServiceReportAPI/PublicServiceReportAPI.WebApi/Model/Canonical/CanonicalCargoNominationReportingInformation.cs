using System;

namespace PublicServiceReportAPI.WebApi.Model.Canonical
{
    public class CanonicalCargoNominationReportingInformation
    {

        public string Cargo_Nomination_Id {get;set;}
        public long IMO {get;set;}
        public string Bill_Of_Lading_Date {get;set;}
        public string Voyage_Number {get;set;}
        public string Voyage_Leg {get;set;}
        public string Inco_Term {get;set;}
        public string Seller_Code {get;set;}
        public string Seller_Name {get;set;}
        public string Loading_Port_Code {get;set;}
        public string Other_Destination_From {get;set;}
        public string Buyer_Code {get;set;}
        public string Buyer_Name {get;set;}
        public string Discharge_Port_Code {get;set;}
        public string Other_Destination_To {get;set;}
        public Decimal Cargo_Mt {get;set;}
        public long Cargo_TEU {get;set;}
        public string Cargo_Product_Group_Name {get;set;}
        public string Cargo_Product_Name {get;set;}
        public string Cargo_Origin {get;set;}
        public decimal Carbon_Offset_Mt {get;set;}
        public string Carbon_Offset_Reference {get;set;}
        public string Carbon_Offset_Comment {get;set;}
        public DateTime reportingdate { get; set; }
        public string MessageType { get; set; }

    }

}