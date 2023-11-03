using Google.Apis.Auth.OAuth2;
using Google.Apis.Storage.v1.Data;
using Google.Cloud.Storage.V1;
using System;
using System.IO;
using System.Windows.Forms;

namespace eMediShop
{
    public class GoogleStorage
    {
        string credential_path = Application.StartupPath+ "\\exprohelp-203510-165ed44c3d80.json";
        GoogleCredential googleCredential;
        string bucketName = "exprohelp-203510.appspot.com";
        public void UploadFiles(
        string localPath = "d:/salary_slip.pdf",
        string objectName = "my-file-name2")
        {
            if(SetStorageCredentials())
            { 
                var storage = StorageClient.Create();
                
                var fileStream = File.OpenRead(localPath);
                storage.UploadObject(bucketName, objectName, null, fileStream);
                //Console.WriteLine($"Uploaded {objectName}.");
            }
        }

        public void DownloadFiles()
        {
            string fileDownloadPath = @"d:\advertisegc.jpg";
            string objectBlobName = "advertise.jpg";
            //if (SetStorageCredentials())
            //{
                var gcsStorage = StorageClient.Create();
                var outputFile = File.OpenWrite(fileDownloadPath);
                gcsStorage.DownloadObject(bucketName, objectBlobName, outputFile);
            //}
        }

        public bool SetStorageCredentials()
        {
            bool status = true;
            try
            {
                if (File.Exists(credential_path))
                {
                    Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credential_path);
                    using (Stream objStream = new FileStream(Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS"), FileMode.Open, FileAccess.Read))
                        googleCredential = GoogleCredential.FromStream(objStream);
                    // Instantiates a client.
                    //storageClient = StorageClient.Create();
                    //channel = new Grpc.Core.Channel(SpeechClient.DefaultEndpoint.Host, GoogleCredential.ToChannelCredentials());
                }
                else
                {
                    DialogResult result = MessageBox.Show("File " + Path.GetFileName(credential_path) + " does not exist. Please provide the correct path.");
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        status = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                status = false;
            }
            return status;
        }
        private string CreateBucketName()
        {
            string projectId = "exprohelp-203510";
            string bucketname = "exprotest";
            var storage = StorageClient.Create();
            Bucket bucket = new Bucket
            {
                Location = "in",
                Name = bucketname,
                StorageClass = "STANDARD"
            };

            var newlyCreatedBucket = storage.CreateBucket(projectId, bucket);
            return newlyCreatedBucket.ToString();
        }



    }
}
