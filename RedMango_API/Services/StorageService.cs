//using Azure.Storage.Blobs;
//using Azure.Storage.Blobs.Models;

//namespace RedMango_API.Services
//{
//    public class BlobService : IBlobService
//    {
//        private readonly BlobServiceClient _blobClient;

//        public BlobService(BlobServiceClient blobClient)
//        {
//            _blobClient = blobClient;
//        }
//        public async Task<bool> DeleteBlob(string blobName, string containerName)
//        {
//            BlobContainerClient blobContainerClient = _blobClient.GetBlobContainerClient(containerName);
//            BlobClient blobClient = blobContainerClient.GetBlobClient(blobName);

//            return await blobClient.DeleteIfExistsAsync();

//        }

//        public async Task<string> GetBlob(string blobName, string containerName)
//        {
//            BlobContainerClient blobContainerClient = _blobClient.GetBlobContainerClient(containerName);
//            BlobClient blobClient = blobContainerClient.GetBlobClient(blobName);
//            return blobClient.Uri.AbsoluteUri;
//        }

//        public async Task<string> UploadBlob(string blobName, string containerName, IFormFile file)
//        {
//            BlobContainerClient blobContainerClient = _blobClient.GetBlobContainerClient(containerName);
//            BlobClient blobClient = blobContainerClient.GetBlobClient(blobName);
//            var httpHeaders = new BlobHttpHeaders()
//            {
//                ContentType = file.ContentType
//            };
//            var result = await blobClient.UploadAsync(file.OpenReadStream(),httpHeaders);
//            if (result != null)
//            {
//                return await GetBlob(blobName, containerName);
//            }
//            return "";
//        }
//    }
//}


using FirebaseAdmin;
using Firebase.Storage;
using Google.Apis.Auth.OAuth2;
using System.Configuration;
using Microsoft.Identity.Client.Extensions.Msal;

namespace RedMango_API.Services
{
    public class StorageService  : IStorageService
    {
        private readonly FirebaseStorage _storageClient;
        private readonly IConfiguration _configuration;

        // private readonly FirestoreDb _firestoreDb;

        public StorageService(IConfiguration configuration)
        {
            _configuration = configuration;
            // Initialize the Firebase app with the service account credentials
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile("./Services/serviceAccount.json"),
            });
            
            // Get the storage client instance
            _storageClient = new FirebaseStorage("redmango-d7e87.appspot.com");

            // Get the firestore database instance
          //  _firestoreDb = FirestoreDb.Create("your-project-id");
        }

        public async Task<bool> DeleteFile(string fileName, string folderName)
        {
           // Xóa ảnh theo tên url firebase
            await _storageClient.Child(folderName).Child(fileName).DeleteAsync();
            return true;
        }

        public async Task<string> GetFile(string fileName, string folderName)
        {
            // Get the file download URL from the storage bucket
            var url = await _storageClient.Child(folderName).Child(fileName).GetDownloadUrlAsync();

            return url;
        }

        public async Task<string> UploadFile(string fileName, string folderName, IFormFile file)
        {
            // Upload the file to the storage bucket
            await _storageClient.Child(folderName).Child(fileName).PutAsync(file.OpenReadStream());


            return await GetFile(fileName, folderName);
        }
    }
}
