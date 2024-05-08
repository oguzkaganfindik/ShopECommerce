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

                // Decide on the image format based on the file extension
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
                        // If the file extension is not recognized, default to JPEG
                        encoder = new JpegEncoder();
                        break;
                }

                // Save the image to the specified path with the specified encoder
                using (var outputStream = new FileStream(destinationImagePath, FileMode.Create))
                {
                    image.Save(outputStream, encoder);
                }
            }
        }
    }
}
