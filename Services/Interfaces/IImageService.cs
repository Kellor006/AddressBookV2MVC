using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AddressBookV2MVC.Services.Interfaces
{
    public interface IImageService
    {
        public Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);
        public string ConvertByteArrayToFile(byte[] fileData, string extension);
    }
}
