using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.DTOs.SocialMediaDto;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }
        public async Task THardDeleteAsync(int id)
        {
            await _socialMediaDal.HardDeleteAsync(id);
        }

        public async Task TAddAsync(SocialMedia entity)
        {
            await _socialMediaDal.AddAsync(entity);
        }
        public async Task TUpdateAsync(SocialMedia entity)
        {
            await _socialMediaDal.UpdateAsync(entity);
        }
        public async Task TDeleteAsync(SocialMedia entity)
        {
            await _socialMediaDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _socialMediaDal.DeleteAsync(id);
        }

        public async Task<SocialMedia> TGetAsync(Expression<Func<SocialMedia, bool>> predicate)
        {
            return await _socialMediaDal.GetAsync(predicate);
        }

        public async Task<IQueryable<SocialMedia>> TGetAllAsync(Expression<Func<SocialMedia, bool>> predicate = null)
        {
            return await _socialMediaDal.GetAllAsync(predicate);
        }

        public async Task<SocialMedia> TGetByIdAsync(int id)
        {
            return await _socialMediaDal.GetByIdAsync(id);
        }

        public async Task<List<SocialMedia>> TGetListAllAsync()
        {
            return await _socialMediaDal.GetListAllAsync();
        }

        public async Task<IQueryable<SocialMedia>> TGetListByStatusTrueAsync(Expression<Func<SocialMedia, bool>> predicate = null)
        {
            return await _socialMediaDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _socialMediaDal.ToggleStatusAsync(id);
        }
        public async Task TUpdateAsync(UpdateSocialMediaDto updateSocialMediaDto)
        {
            var socialMedia = await _socialMediaDal.GetByIdAsync(updateSocialMediaDto.Id);
            if (socialMedia == null)
            {
                throw new ArgumentException("Varlık bulunamadı");
            }

            socialMedia.Title = updateSocialMediaDto.Title;
            socialMedia.Cls = updateSocialMediaDto.Cls;
            socialMedia.Icon = updateSocialMediaDto.Icon;
            socialMedia.Url = updateSocialMediaDto.Url;
            socialMedia.Status = updateSocialMediaDto.Status;

            await _socialMediaDal.UpdateAsync(socialMedia);
        }

        public async Task TAddAsync(CreateSocialMediaDto createSocialMediaDto)
        {
            await _socialMediaDal.AddAsync(new SocialMedia()
            {
                Title = createSocialMediaDto.Title,
                Cls = createSocialMediaDto.Cls,
                Icon = createSocialMediaDto.Icon,
                Url = createSocialMediaDto.Url,
                Status = createSocialMediaDto.Status
            });
        }
    }
}
