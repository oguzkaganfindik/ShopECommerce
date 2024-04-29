﻿using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;

namespace ShopECommerce.Data.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly ShopECommerceContext _context;

        public GenericRepository(ShopECommerceContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
