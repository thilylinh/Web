using System.Collections.Generic;
using System.Linq;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface IProductCategoryReponsitory
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryReponsitory : RepositoryBase<ProductCategory>, IProductCategoryReponsitory
    {
        public ProductCategoryReponsitory(Dbfactory dbfactory) : base(dbfactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.productCategories.Where(x => x.Alias == alias);
        }
    }
}