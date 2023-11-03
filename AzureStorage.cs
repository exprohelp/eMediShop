using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.IO;

namespace eMediShop
{
    public class azurestorage
    {
        private static string ConnectionSting
        {
            get
            {
                return "DefaultEndpointsProtocol=https;AccountName=exprocloudcstorage;AccountKey=+NofFlFxbkqFUd4SV+OMKA55+goISyLK8bAcKKFX3sjLitNHRHVdzYp4lX1rBvH6EWQn8kIPi5cx4/qj+zvkmQ==;EndpointSuffix=core.windows.net";
            }
        }

        public static bool Upload(string unitID,string typedoc,string filenamewithpath)
        {
            try
            {
                FileInfo fi = new FileInfo(filenamewithpath);
                // set your container name
                var containerName = "pharmacydocs";

                // create object of storage account
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ConnectionSting);

                // create client of storage account
                CloudBlobClient client = storageAccount.CreateCloudBlobClient();

                // create the reference of your storage account
                CloudBlobContainer container = client.GetContainerReference(containerName);

                // check if the container exists or not in your account
                var isCreated = container.CreateIfNotExists();
                
                // set the permission to blob type
                container.SetPermissionsAsync(new BlobContainerPermissions
                { PublicAccess = BlobContainerPublicAccessType.Blob });

                // read the file to be uploaded
                using (FileStream fileStream = File.Open(filenamewithpath, FileMode.Open))
                {
                    // create the memory steam which will be uploaded
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        // set the memory stream position to starting
                        memoryStream.Position = 0;

                        // copy file content to memory stream
                        fileStream.CopyTo(memoryStream);

                        var fileName =unitID+"/"+typedoc+"/"+fi.Name;
                        // create the object of blob which will be created
                        // Test-log.txt is the name of the blob, pass your desired name
                        CloudBlockBlob blob = container.GetBlockBlobReference(fileName);

                        // get the mime type of the file
                        string mimeType = "application/unknown";
                        string ext = (fileName.Contains(".")) ?
                                    System.IO.Path.GetExtension(fileName).ToLower() : "." + fileName;
                        Microsoft.Win32.RegistryKey regKey =
                                    Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
                        if (regKey != null && regKey.GetValue("Content Type") != null)
                            mimeType = regKey.GetValue("Content Type").ToString();

                        // set the memory stream position to zero again
                        // this is one of the important stage, If you miss this step, 
                        // your blob will be created but size will be 0 byte
                        memoryStream.ToArray();
                        memoryStream.Seek(0, SeekOrigin.Begin);

                        // set the mime type
                        blob.Properties.ContentType = mimeType;

                        // upload the stream to blob
                        blob.UploadFromStream(memoryStream);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static MemoryStream Download(string blobName)
        {
            var containerName = "pharmacydocs";
            //var blobName = "shareReport.xlsx";
            // create object of your storage account
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ConnectionSting);

            // create the client of your storage account
            CloudBlobClient client = storageAccount.CreateCloudBlobClient();

            // create reference of container
            CloudBlobContainer container = client.GetContainerReference(containerName);

            // get a particular blob within that container
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(blobName);

            // get list of all blobs in the container
            var allBlobs = container.ListBlobs();

            // convert the blob to memorystream
            MemoryStream memStream = new MemoryStream();
            blockBlob.DownloadToStream(memStream);
            return memStream;
        }
        public static bool DeleteBlob()
        {
            var containerName = "pharmacydocs";
            var blobName = "exprocloudcstorage";
            // create object of your storage account
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ConnectionSting);

            // create the client of your storage account
            CloudBlobClient client = storageAccount.CreateCloudBlobClient();

            // create reference of container
            CloudBlobContainer container = client.GetContainerReference(containerName);

            // get a particular blob within that container
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(blobName);

            // delete the blob and return bool
            return blockBlob.DeleteIfExists();
        }
    }
}
