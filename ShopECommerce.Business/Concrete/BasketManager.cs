﻿using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.DTOs.BasketDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Concrete
{
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public void TAdd(Basket entity)
        {
            _basketDal.Add(entity);
        }

        public void TDelete(Basket entity)
        {
            _basketDal.Delete(entity);
        }

        public List<Basket> TGetBasketByMenuTableNumber(int id)
        {
            return _basketDal.GetBasketByMenuTableNumber(id);
        }

        public List<ResultBasketListWithProductsDto> TGetBasketListByMenuTableWithProductName(int id)
        {
            return _basketDal.GetBasketListByMenuTableWithProductName(id);
        }

        public Basket TGetById(int id)
        {
            return _basketDal.GetById(id);
        }

        public List<Basket> TGetListAll()
        {
            return _basketDal.GetListAll();
        }

        public decimal TGetProductPrice(int productId)
        {
            return _basketDal.GetProductPrice(productId);
        }

        public void TUpdate(Basket entity)
        {
            _basketDal.Update(entity);
        }
    }
}