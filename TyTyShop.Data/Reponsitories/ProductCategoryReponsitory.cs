using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface IProductCategoryReponsitory : IReponsitory<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryReponsitory : RepositoryBase<ProductCategory>, IProductCategoryReponsitory
    {
        public ProductCategoryReponsitory(Dbfactory dbfactory) : base(dbfactory)
        {
        }

        public bool CheckContaints(Expression<Func<ProductCategory, bool>> preditcate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.productCategories.Where(x => x.Alias == alias);
        }
    }
}