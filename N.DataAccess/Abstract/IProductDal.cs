using System.Collections.Generic;
using N.Entites.Concrete;

namespace N.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        Product Get(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}