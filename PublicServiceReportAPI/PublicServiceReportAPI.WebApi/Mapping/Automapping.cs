using AutoMapper;
using PublicServiceReportAPI.WebApi.Model.Public;
using PublicServiceReportAPI.WebApi.Model.Canonical;

namespace PublicServiceReportAPI.WebApi.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<ReportingServiceInformation, CanonicalReportingServiceInformation>();
        }
    }   

}