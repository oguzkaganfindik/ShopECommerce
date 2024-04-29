﻿using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
    {
        private readonly ShopECommerceContext _context;
        public EfMoneyCaseDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }

        public decimal TotalMoneyCaseAmount()
        {
            return _context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();
        }
    }
}
