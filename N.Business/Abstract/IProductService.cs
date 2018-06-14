using System.Collections.Generic;
using N.Entites.Concrete;

namespace N.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}