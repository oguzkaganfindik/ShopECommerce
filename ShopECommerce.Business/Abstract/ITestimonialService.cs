using ShopECommerce.DTOs.TestimonialDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface ITestimonialService : IGenericService<Testimonial>
    {
        Task TUpdateAsync(UpdateTestimonialDto updateTestimonialDto);
        Task TAddAsync(CreateTestimonialDto createTestimonialDto);
    }
}
