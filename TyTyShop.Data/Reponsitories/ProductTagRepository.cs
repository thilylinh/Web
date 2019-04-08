using System;
using System.Linq.Expressions;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface IProductTagRepository: IReponsitory<ProductTag>
    {
    }

    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(Dbfactory dbfactory) : base(dbfactory)
        {
        }

        public bool CheckContaints(Expression<Func<ProductTag, bool>> preditcate)
        {
            throw new NotImplementedException();
        }
    }
}