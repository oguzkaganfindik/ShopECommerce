using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.DTOs.FeaturDto;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class FeaturManager : IFeaturService
    {
        private readonly IFeaturDal _featurDal;

        public FeaturManager(IFeaturDal featurDal)
        {
            _featurDal = featurDal;
        }

        public async Task THardDeleteAsync(int id)
        {
            await _featurDal.HardDeleteAsync(id);
        }

        public async Task TAddAsync(Featur entity)
        {
            await _featurDal.AddAsync(entity);
        }
        public async Task TUpdateAsync(Featur entity)
        {
            await _featurDal.UpdateAsync(entity);
        }
        public async Task TDeleteAsync(Featur entity)
        {
            await _featurDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _featurDal.DeleteAsync(id);
        }

        public async Task<Featur> TGetAsync(Expression<Func<Featur, bool>> predicate)
        {
            return await _featurDal.GetAsync(predicate);
        }

        public async Task<IQueryable<Featur>> TGetAllAsync(Expression<Func<Featur, bool>> predicate = null)
        {
            return await _featurDal.GetAllAsync(predicate);
        }

        public async Task<Featur> TGetByIdAsync(int id)
        {
            return await _featurDal.GetByIdAsync(id);
        }

        public async Task<List<Featur>> TGetListAllAsync()
        {
            return await _featurDal.GetListAllAsync();
        }

        public async Task<IQueryable<Featur>> TGetListByStatusTrueAsync(Expression<Func<Featur, bool>> predicate = null)
        {
            return await _featurDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _featurDal.ToggleStatusAsync(id);
        }
        public async Task TUpdateAsync(UpdateFeaturDto updateFeaturDto)
        {
            var featur = await _featurDal.GetByIdAsync(updateFeaturDto.Id);
            if (featur == null)
            {
                throw new ArgumentException("Varlık bulunamadı");
            }

            featur.Title = updateFeaturDto.Title;
            featur.Description = updateFeaturDto.Description;
            featur.Icon = updateFeaturDto.Icon;
            featur.Status = updateFeaturDto.Status;

            await _featurDal.UpdateAsync(featur);
        }

        public async Task TAddAsync(CreateFeaturDto createFeaturDto)
        {
            await _featurDal.AddAsync(new Featur()
            {
                Title = createFeaturDto.Title,
                Description = createFeaturDto.Description,
                Icon = createFeaturDto.Icon,
                Status = createFeaturDto.Status
            });
        }
    }
}
