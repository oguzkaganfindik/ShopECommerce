using ShopECommerce.Entities.Concrete;
using ShopECommerce.WebUI.Services.Abstract;

namespace ShopECommerce.WebUI.Services.Concrete
{
    public class ImageManager : IImageService
    {
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _environment;
        private readonly IImageProcessingService _imageProcessingService;

        public ImageManager(Microsoft.AspNetCore.Hosting.IHostingEnvironment environment, IImageProcessingService imageProcessingService)
        {
            _environment = environment;
            _imageProcessingService = imageProcessingService;
        }

        public string Image(IFormFile formFile, string filePath, out string errorMessage, string Patch1, string Patch2)
        {
            var newFileName = "";

            errorMessage = "";

            if (formFile != null && formFile.FileName != null) // dosya yüklenmek isteniyorsa
            {
                var allowedFileTypes = new string[] { "image/jpeg", "image/jpg", "image/jfif", "image/avif" };

                var allowedFileExtensions = new string[] { ".jpg", ".jpeg", ".png", ".jfif", ".avif" };

                var fileContentType = formFile.ContentType;
                var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(formFile.FileName);
                var fileExtension = Path.GetExtension(formFile.FileName);

                if (!allowedFileTypes.Contains(fileContentType) || !allowedFileExtensions.Contains(fileExtension))
                {
                    errorMessage = "Yüklediğiniz dosya " + fileExtension + " uzantısında. Sisteme yalnızca .jpg .jpeg .jfif .avif formatında dosyalar yüklenebilir.";
                }
                else
                {
                    newFileName = fileNameWithoutExtension + "-" + Guid.NewGuid() + fileExtension;
                    var folderPath = Path.Combine(Patch1, Patch2);
                    var wwwrootFolderPath = Path.Combine(_environment.WebRootPath, folderPath);
                    Directory.CreateDirectory(wwwrootFolderPath);
                    filePath = Path.Combine(wwwrootFolderPath, newFileName);

                    // Resmi boyutlandırma
                    _imageProcessingService.ResizeImage(formFile.OpenReadStream(), filePath, 500, 350);
                }
            }

            return newFileName;
        }
    }
}