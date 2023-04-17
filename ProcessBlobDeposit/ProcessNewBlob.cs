using System;
using System.IO;
using Azure.Storage.Blobs;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ProcessBlobDeposit
{
    public class ProcessNewBlob
    {
        [FunctionName("ProcessNewBlob")]
        public void Run([BlobTrigger("samples-workitems/{name}", Connection = "BlobContainerConnectionString")] Stream inboundBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {inboundBlob.Length} Bytes.");
        }
    }
}
