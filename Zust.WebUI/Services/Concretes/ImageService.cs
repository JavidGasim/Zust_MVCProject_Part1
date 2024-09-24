using Zust.WebUI.Services.Abstracts;

namespace Zust.WebUI.Services.Concretes
{
    public class ImageService : IImageService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ImageService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<string> SaveImageAsync(IFormFile file)
        {
            var saveImage = Path.Combine(_webHostEnvironment.WebRootPath, "images", file.FileName);

            using (var img = new FileStream(saveImage, FileMode.OpenOrCreate))
            {
                await file.CopyToAsync(img);
            }

            return file.FileName.ToString();
        }
    }
}
