using ImageMagick;
using Microsoft.AspNetCore.Http;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStayMVC.Utility
{
    public class BlobUtility
    {
        private readonly CloudBlobClient blobClient;
        public BlobUtility(string accoutName, string accountKey)
        {
            CloudStorageAccount cloudStorageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=" + accoutName + ";AccountKey=" + accountKey + ";EndpointSuffix=core.windows.net");

             blobClient = cloudStorageAccount.CreateCloudBlobClient();
        }

        public async Task UploadBlob(string blobContainer, IFormFile file)
        {
            int fileNameStartLocation = file.FileName.LastIndexOf("\\") + 1;
            string fileName = file.FileName.Substring(fileNameStartLocation);

            CloudBlobContainer container = blobClient.GetContainerReference(blobContainer);
            await container.CreateIfNotExistsAsync();

            await container.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });

            CloudBlockBlob cloudBlockBlob = container.GetBlockBlobReference(fileName);

            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();

            MagickImage image = new MagickImage(file.OpenReadStream());

            image.AutoOrient();

            await memoryStream.WriteAsync(image.ToByteArray(), 0, image.ToByteArray().Count());

            memoryStream.Position = 0;

            await cloudBlockBlob.UploadFromStreamAsync(memoryStream);
        }

        public async Task<List<IListBlobItem>> GetBlobs(string blobContainer)
        {
            CloudBlobContainer container = blobClient.GetContainerReference(blobContainer);
            await container.CreateIfNotExistsAsync();

            await container.SetPermissionsAsync(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });

            BlobContinuationToken continuationToken = null;
            List<IListBlobItem> blobItems = new List<IListBlobItem>();

            do
            {
                var response = await container.ListBlobsSegmentedAsync(continuationToken);
                continuationToken = response.ContinuationToken;
                blobItems.AddRange(response.Results);
            }
            while (continuationToken != null);

            return blobItems;
        }
    }
}
