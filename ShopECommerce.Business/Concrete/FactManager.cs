using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.DTOs.FactDto;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class FactManager : IFactService
    {
        private readonly IFactDal _factDal;

        public FactManager(IFactDal factDal)
        {
            _factDal = factDal;
        }

        public async Task THardDeleteAsync(int id)
        {
            await _factDal.HardDeleteAsync(id);
        }

        public async Task TAddAsync(Fact entity)
        {
            await _factDal.AddAsync(entity);
        }
        public async Task TUpdateAsync(Fact entity)
        {
            await _factDal.UpdateAsync(entity);
        }
        public async Task TDeleteAsync(Fact entity)
        {
            await _factDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _factDal.DeleteAsync(id);
        }

        public async Task<Fact> TGetAsync(Expression<Func<Fact, bool>> predicate)
        {
            return await _factDal.GetAsync(predicate);
        }

        public async Task<IQueryable<Fact>> TGetAllAsync(Expression<Func<Fact, bool>> predicate = null)
        {
            return await _factDal.GetAllAsync(predicate);
        }

        public async Task<Fact> TGetByIdAsync(int id)
        {
            return await _factDal.GetByIdAsync(id);
        }

        public async Task<List<Fact>> TGetListAllAsync()
        {
            return await _factDal.GetListAllAsync();
        }

        public async Task<IQueryable<Fact>> TGetListByStatusTrueAsync(Expression<Func<Fact, bool>> predicate = null)
        {
            return await _factDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _factDal.ToggleStatusAsync(id);
        }
        public async Task TUpdateAsync(UpdateFactDto updateFactDto)
        {
            var fact = await _factDal.GetByIdAsync(updateFactDto.Id);
            if (fact == null)
            {
                throw new ArgumentException("Varlık bulunamadı");
            }

            fact.Title = updateFactDto.Title;
            fact.Description = updateFactDto.Description;
            fact.Icon = updateFactDto.Icon;
            fact.Status = updateFactDto.Status;

            await _factDal.UpdateAsync(fact);
        }

        public async Task TAddAsync(CreateFactDto createFactDto)
        {
            await _factDal.AddAsync(new Fact()
            {
                Title = createFactDto.Title,
                Description = createFactDto.Description,
                Icon = createFactDto.Icon,
                Status = createFactDto.Status
            });
        }
    }
}
