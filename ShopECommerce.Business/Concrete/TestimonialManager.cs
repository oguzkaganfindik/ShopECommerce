﻿using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.DTOs.TestimonialDto;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public async Task THardDeleteAsync(int id)
        {
            await _testimonialDal.HardDeleteAsync(id);
        }

        public async Task TAddAsync(Testimonial entity)
        {
            await _testimonialDal.AddAsync(entity);
        }
        public async Task TUpdateAsync(Testimonial entity)
        {
            await _testimonialDal.UpdateAsync(entity);
        }
        public async Task TDeleteAsync(Testimonial entity)
        {
            await _testimonialDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _testimonialDal.DeleteAsync(id);
        }

        public async Task<Testimonial> TGetAsync(Expression<Func<Testimonial, bool>> predicate)
        {
            return await _testimonialDal.GetAsync(predicate);
        }

        public async Task<IQueryable<Testimonial>> TGetAllAsync(Expression<Func<Testimonial, bool>> predicate = null)
        {
            return await _testimonialDal.GetAllAsync(predicate);
        }

        public async Task<Testimonial> TGetByIdAsync(int id)
        {
            return await _testimonialDal.GetByIdAsync(id);
        }

        public async Task<List<Testimonial>> TGetListAllAsync()
        {
            return await _testimonialDal.GetListAllAsync();
        }

        public async Task<IQueryable<Testimonial>> TGetListByStatusTrueAsync(Expression<Func<Testimonial, bool>> predicate = null)
        {
            return await _testimonialDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _testimonialDal.ToggleStatusAsync(id);
        }
        
        public async Task TUpdateAsync(UpdateTestimonialDto updateTestimonialDto)
        {
            var testimonial = await _testimonialDal.GetByIdAsync(updateTestimonialDto.Id);
            if (testimonial == null)
            {
                throw new ArgumentException("Varlık bulunamadı");
            }

            testimonial.Name = updateTestimonialDto.Name;
            testimonial.Title = updateTestimonialDto.Title;
            testimonial.Comment = updateTestimonialDto.Comment;
            testimonial.ImagePath = updateTestimonialDto.ImagePath;
            testimonial.Status = updateTestimonialDto.Status;

            await _testimonialDal.UpdateAsync(testimonial);
        }

        public async Task TAddAsync(CreateTestimonialDto createTestimonialDto)
        {
            await _testimonialDal.AddAsync(new Testimonial()
            {
                Name = createTestimonialDto.Name,
                Title = createTestimonialDto.Title,
                Comment = createTestimonialDto.Comment,
                ImagePath = createTestimonialDto.ImagePath,
                Status = createTestimonialDto.Status
            });
        }
    }
}
