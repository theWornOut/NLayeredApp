﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using N.DataAccess.Abstract;
using N.Entites.Concrete;

namespace N.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId = 1, ProductName = "Laptop", QuantityPerUnit = "1 in a box", UnitPrice = 3000, UnitsInStock = 11}
            };
            return products;
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}