using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;

namespace KouameKISSAzureBlobStorageConsoleApplication
{
    class ClientLibraryContainerManipulationDemo
    {
        public static string StorageConnection { get; private set; }

        static void Main(string[] args)
        {
            var StorageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("StorageConnection"));

            var blobClient = StorageAccount.CreateCloudBlobClient();

            var container = blobClient.GetContainerReference("HelloWorld");

            container.CreateIfNotExists(BlobContainerPublicAccessType.Blob);

            Console.ReadKey();
        }
    }
}
