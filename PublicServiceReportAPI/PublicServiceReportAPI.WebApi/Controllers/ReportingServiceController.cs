using Microsoft.AspNetCore.Mvc;
using System.Text;
using AutoMapper;
using System.Collections.Generic;
using Microsoft.ApplicationInsights;
using PublicServiceReportAPI.WebApi.interfaces;
using PublicServiceReportAPI.WebApi.Model.Public;
using PublicServiceReportAPI.WebApi.Model.Canonical;


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

        [Route("shipinformationsingle", Name = "01. ShipInformationSingle")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task <IActionResult> CreateCustomerInformationSingle([FromBody] ReportingServiceInformation shipreporting)
        {
                    var queueCustomerOrder = _storageProvider.GetQueue("reporting-queue");
                    var tasks = new List<Task>();
                    var payload = _mapper.Map<CanonicalReportingServiceInformation>(shipreporting);
                    payload.MessageType = "ShipLogInformationSingle";

                    var json = await submitAsTempBlob(payload.SerializeJson());

                    tasks.Add(queueCustomerOrder.SendMessageAsync(json));





                if (tasks.Any(t => t.IsFaulted))
                {
                    _telemetryClient.TrackException(tasks.First(t => t.IsFaulted).Exception, new Dictionary<string, string> { { "WriteToInboundQueue", "1" } });
                }


            return new OkResult();
        }

        [Route("shipinformationbatch", Name = "02. ShipInformationBatch")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task <IActionResult> CreateCustomerInformationBatch([FromBody] List<ReportingServiceInformation> ShipReportBatch)
        {
            var queueCustomerOrder = _storageProvider.GetQueue("customerinformationbatchqueue");
            var tasks = new List<Task>();

                foreach (var shiprep in ShipReportBatch)
                {
                    var payload = _mapper.Map<CanonicalReportingServiceInformation>(shiprep);
                    payload.MessageType = "ShipLogInformationBatch";
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