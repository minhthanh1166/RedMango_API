namespace RedMango_API.Services
{
    public interface IStorageService
    {
        //Task<string> GetBlob(string blobName, string containerName);
        //Task<bool> DeleteBlob(string blobName, string containerName);
        //Task<string> UploadBlob(string blobName, string containerName, IFormFile file);
        Task<bool> DeleteFile(string fileName, string folderName);
        Task<string> GetFile(string fileName, string folderName);
        Task<string> UploadFile(string fileName, string folderName, IFormFile file);
    }
}
