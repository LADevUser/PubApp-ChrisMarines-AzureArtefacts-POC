using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System;

namespace PublicServiceReportAPI.WebApi.Model.Public
{   
    public class CargoNominationReportIngInformation
    {  
        [Required]
        [MaxLength(30)]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Cargo_Nomination_Id {get;set;}
        
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public long IMO {get;set;}
        
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Bill_Of_Lading_Date {get;set;}
        
        [Required]
        [MaxLength(30)]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Voyage_Number {get;set;}
        
        [Required]
        [MaxLength(30)]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Voyage_Leg {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Inco_Term {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Seller_Code {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Seller_Name {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Loading_Port_Code {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Other_Destination_From {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Buyer_Code {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Buyer_Name {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Discharge_Port_Code {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Other_Destination_To {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Cargo_Mt {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long? Cargo_TEU {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Cargo_Product_Group_Name {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Cargo_Product_Name {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Cargo_Origin {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Carbon_Offset_Mt {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Carbon_Offset_Reference {get;set;}
        
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Carbon_Offset_Comment {get;set;}
    }
}