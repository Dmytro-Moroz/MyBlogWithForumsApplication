using Microsoft.WindowsAzure.Storage.Blob;

namespace MyBlogApp.DataAccess
{
    public interface IUpload
    {
        CloudBlobContainer GetBlobContainer(string connectionString, string containerName);
    }
}
