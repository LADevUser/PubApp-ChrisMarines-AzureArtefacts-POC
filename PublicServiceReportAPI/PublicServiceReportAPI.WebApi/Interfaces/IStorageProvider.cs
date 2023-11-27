using Azure.Storage.Blobs;
using Azure.Storage.Queues;

namespace PublicServiceReportAPI.WebApi.interfaces 
{
      public interface IStorageProvider
    {
        BlobClient GetBlobContainer();
        QueueClient GetQueue(string queueName);
       // QueueClient GetQueueByType(QueueType type, string prio, string sandbox);
    }
}
  