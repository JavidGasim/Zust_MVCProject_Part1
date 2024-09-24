namespace Zust.WebUI.Services.Abstracts
{
    public interface IImageService
    {
        Task<string> SaveImageAsync(IFormFile file);
    }
}
