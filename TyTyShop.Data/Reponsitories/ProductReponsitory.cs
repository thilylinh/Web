using System;
using System.Linq.Expressions;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface IProductReponsitory : IReponsitory<Product>
    {

    }

    public class ProductReponsitory : RepositoryBase<Product>,IProductReponsitory
    {
        public ProductReponsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public bool CheckContaints(Expression<Func<Product, bool>> preditcate)
        {
            throw new NotImplementedException();
        }
    }
}