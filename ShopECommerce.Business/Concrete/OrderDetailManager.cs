﻿using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Concrete;
using ShopECommerce.DTOs.AboutDto;
using ShopECommerce.DTOs.OrderDetailDto;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IOrderDetailDal _orderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

        public async Task THardDeleteAsync(int id)
        {
            await _orderDetailDal.HardDeleteAsync(id);
        }

        public async Task TAddAsync(OrderDetail entity)
        {
            await _orderDetailDal.AddAsync(entity);
        }
        public async Task TUpdateAsync(OrderDetail entity)
        {
            await _orderDetailDal.UpdateAsync(entity);
        }
        public async Task TDeleteAsync(OrderDetail entity)
        {
            await _orderDetailDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _orderDetailDal.DeleteAsync(id);
        }

        public async Task<OrderDetail> TGetAsync(Expression<Func<OrderDetail, bool>> predicate)
        {
            return await _orderDetailDal.GetAsync(predicate);
        }

        public async Task<IQueryable<OrderDetail>> TGetAllAsync(Expression<Func<OrderDetail, bool>> predicate = null)
        {
            return await _orderDetailDal.GetAllAsync(predicate);
        }

        public async Task<OrderDetail> TGetByIdAsync(int id)
        {
            return await _orderDetailDal.GetByIdAsync(id);
        }

        public async Task<List<OrderDetail>> TGetListAllAsync()
        {
            return await _orderDetailDal.GetListAllAsync();
        }

        public async Task<IQueryable<OrderDetail>> TGetListByStatusTrueAsync(Expression<Func<OrderDetail, bool>> predicate = null)
        {
            return await _orderDetailDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _orderDetailDal.ToggleStatusAsync(id);
        }

        public async Task TUpdateAsync(UpdateOrderDetailDto updateOrderDetailDto)
        {
            var orderDetail = await _orderDetailDal.GetByIdAsync(updateOrderDetailDto.Id);
            if (orderDetail == null)
            {
                throw new ArgumentException("Varlık bulunamadı");
            }

            orderDetail.OrderId = updateOrderDetailDto.OrderId;
            orderDetail.ProductId = updateOrderDetailDto.ProductId;
            orderDetail.Count = updateOrderDetailDto.Count;
            orderDetail.TotalPrice = updateOrderDetailDto.TotalPrice;
            orderDetail.UnitPrice = updateOrderDetailDto.UnitPrice;
            orderDetail.Status = updateOrderDetailDto.Status;

            await _orderDetailDal.UpdateAsync(orderDetail);
        }

        public async Task TAddAsync(CreateOrderDetailDto createOrderDetailDto)
        {
            await _orderDetailDal.AddAsync(new OrderDetail()
            {
                OrderId = createOrderDetailDto.OrderId,
                ProductId = createOrderDetailDto.ProductId,
                Count = createOrderDetailDto.Count,
                TotalPrice = createOrderDetailDto.TotalPrice,
                UnitPrice = createOrderDetailDto.UnitPrice,
                Status = createOrderDetailDto.Status
            });
        }
    }
}
