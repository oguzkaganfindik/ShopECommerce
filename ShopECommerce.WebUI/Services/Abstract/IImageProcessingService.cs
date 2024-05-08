namespace ShopECommerce.WebUI.Services.Abstract
{
    public interface IImageProcessingService
    {
        void ResizeImage(Stream sourceStream, string destinationImagePath, int width, int height);
    }
}
