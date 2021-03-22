using System;
using System.IO;
using System.Threading.Tasks;

namespace DotnetcoreLineBot.Interfaces
{
    public interface IImageService
    {
        Task<string> UploadImageAsync(Stream stream);
    }
}
