using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface IProductReponsitory
    {

    }

    public class ProductReponsitory : RepositoryBase<Product>
    {
        public ProductReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}