using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Queues;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net;
using PublicServiceReportAPI.WebApi.interfaces;

namespace PublicServiceReportAPI.WebApi.Helpers
{
public class StorageProvider : IStorageProvider
    {

            private readonly BlobClient _blobClient;
            private BlobContainerClient _blobContainer;
            private readonly QueueClient _queueClient;
            private readonly Dictionary<string, QueueClient> _queues = new Dictionary<string, QueueClient>();
            private string connector ;

            public StorageProvider(IConfiguration config)
            {
                connector = config.GetConnectionString("ShipreportingSAConnectionString");


            }

        public BlobClient GetBlobContainer()
        {
            if (_blobContainer is null)
            {
                _blobContainer = new BlobContainerClient(connector, "ShipJsonContainer");
                _blobContainer.CreateIfNotExists();
            }

            BlobClient blob = _blobContainer.GetBlobClient("SingleShipJsonFiles");

           return blob;
        }

        public QueueClient GetQueue(string queueName)
        {
            if(!_queues.TryGetValue(queueName, out QueueClient queue))
            {
                queue = new QueueClient(connector, queueName);
                queue.CreateIfNotExists();
                _queues.Add(queueName, queue);
            }

            return queue;
        }


    }
}