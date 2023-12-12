using Microsoft.AspNetCore.Mvc;
using System.Text;
using AutoMapper;
using System.Collections.Generic;
using Microsoft.ApplicationInsights;
using PublicServiceReportAPI.WebApi.interfaces;
using OVDInterfaceModelPackage.Model.Public.OVDReportingApi.MainModels;
using OVDInterfaceModelPackage.Model.Internal.Canonical.OVDReportingApi.MainModels;


namespace PublicServiceReportAPI.WebApi.Controllers
{
    [ApiController]
    [Route("v1")]
    public class ReportingServiceController : ControllerBase
    {
        private readonly ILogger<ReportingServiceController> _logger;
        private IStorageProvider _storageProvider;
        private TelemetryClient _telemetryClient;
        private IMapper _mapper;
        public ReportingServiceController(ILogger<ReportingServiceController> logger, IStorageProvider SaResolver,TelemetryClient telemetryClient, IMapper mapper)
        {
            _mapper = mapper;
            _logger = logger;
            _storageProvider = SaResolver;
            _telemetryClient = telemetryClient;
        }

        [Route("logabstractreport", Name = "01. LogAbstractReport")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task <IActionResult> CreateLogAbstractReport([FromBody] LogAbstractReportingInformation logabstractreport)
        {
                    var tasks = new List<Task>();    
                    
                    var payload = _mapper.Map<LogAbstractReportingInformationCanonical>(logabstractreport);
                    payload.MessageType = "LogAbstractReport";
                    payload.reportingdate = DateTime.UtcNow;

                    var json = await submitAsTempBlob(payload.SerializeJson());

                    var queueCustomerOrder = _storageProvider.GetQueue("logreports");
                    tasks.Add(queueCustomerOrder.SendMessageAsync(json));





                if (tasks.Any(t => t.IsFaulted))
                {
                    _telemetryClient.TrackException(tasks.First(t => t.IsFaulted).Exception, new Dictionary<string, string> { { "WriteToInboundQueue", "1" } });
                }


            return new OkResult();
        }

        [Route("bunkerreporting", Name = "02. BunkerReport")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task <IActionResult> CreateBunkerReport([FromBody] List<BunkerReportIngInformation> bunkerreporting)
        {
            var queueCustomerOrder = _storageProvider.GetQueue("bunkerreports");
            var tasks = new List<Task>();

                foreach (var bunkerreport in bunkerreporting)
                {
                    var payload = _mapper.Map<BunkerReportIngInformationCanonical>(bunkerreport);
                    payload.MessageType = "BunkerReport";
                    payload.reportingdate = DateTime.UtcNow;
                    var json = await determineSubmissionType(payload.SerializeJson());

                    tasks.Add(queueCustomerOrder.SendMessageAsync(json));

                }

                await Task.WhenAll(tasks);

                if (tasks.Any(t => t.IsFaulted))
                {
                    _telemetryClient.TrackException(tasks.First(t => t.IsFaulted).Exception, new Dictionary<string, string> { { "WriteToInboundQueue", "1" } });
                }


            return new OkResult();
        }        

        private async Task<string> submitAsTempBlob(string json)
        {
        // For large messages, put the content on blob storage and 
        // replace message with reference id.
        //if (json.Length > 40000)
        //{
        //    var guid = Guid.NewGuid().ToString();
        //    var container = _storageProvider.GetBlobContainer();  
        //    using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        //    {
        //        await container.UploadAsync(ms);
        //    }          
//
        //    json = $"reference:{guid}";
        //}
        return json;
        }

        private async Task<string> determineSubmissionType(string json)
        {
        // For large messages, put the content on blob storage and 
        // replace message with reference id.
        //if (json.Length > 40000)
        //{
        //    var guid = Guid.NewGuid().ToString();
        //    var container = _storageProvider.GetBlobContainer();  
        //    using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        //    {
        //        await container.UploadAsync(ms);
        //    }          
//
        //    json = $"reference:{guid}";
        //}
        return json;
        }

    }
}   