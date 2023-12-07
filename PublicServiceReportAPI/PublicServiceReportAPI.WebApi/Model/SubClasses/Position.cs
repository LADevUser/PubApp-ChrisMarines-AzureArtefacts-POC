using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PublicServiceReportAPI.WebApi.Model.Subclasses
{
    public class Position
    {
        public Latitude latitude {get; set;}
        public Longitude longitude {get; set;}
    }

}