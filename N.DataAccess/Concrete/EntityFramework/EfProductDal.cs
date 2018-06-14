using N.DataAccess.Abstract;
using N.Entites.Concrete;

namespace N.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NContext>, IProductDal
    {

    }
}