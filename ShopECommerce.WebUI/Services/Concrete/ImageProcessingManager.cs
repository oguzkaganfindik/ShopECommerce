using ShopECommerce.WebUI.Services.Abstract;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Processing;

namespace ShopECommerce.WebUI.Services.Concrete
{
    public class ImageProcessingManager : IImageProcessingService
    {
        public void ResizeImage(Stream sourceStream, string destinationImagePath, int width, int height)
        {
            using (var image = Image.Load(sourceStream))
            {
                image.Mutate(x => x.Resize(width, height));

                
                IImageEncoder encoder;
                var extension = Path.GetExtension(destinationImagePath).ToLowerInvariant();
                switch (extension)
                {
                    case ".jpg":
                    case ".jpeg":
                        encoder = new JpegEncoder();
                        break;
                    case ".png":
                        encoder = new PngEncoder();
                        break;
                    default:
                        
                        encoder = new JpegEncoder();
                        break;
                }
              
                using (var outputStream = new FileStream(destinationImagePath, FileMode.Create))
                {
                    image.Save(outputStream, encoder);
                }
            }
        }
    }
}
