using System.Collections.Generic;
using System.Linq;
using N.DataAccess.Abstract;
using N.Entites.Concrete;

namespace N.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            using (var context = new NContext())
            {
                return context.Products.ToList();
            }
        }

        public Product Get(int id)
        {
            using (var context = new NContext())
            {
                return context.Products.SingleOrDefault(x => x.ProductId == id);
            }
        }

        public void Add(Product product)
        {
            using (var context = new NContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (var context = new NContext())
            {
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (var context = new NContext())
            {
                context.SaveChanges();
            }
        }
    }
}