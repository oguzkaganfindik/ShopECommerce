namespace ShopECommerce.WebUI.Services.Abstract
{
    public interface IImageService
    {
        string Image(IFormFile formFile, string filePath, out string errorMessage, string Patch1, string Patch2, int width, int height);
    }
}