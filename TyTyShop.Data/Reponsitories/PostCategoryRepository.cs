using System;
using System.Linq.Expressions;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface IPostCategoryRepository : IReponsitory<Postcategory>
    {
    }

    public class PostCategoryRepository : RepositoryBase<Postcategory>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public bool CheckContaints(Expression<Func<Postcategory, bool>> preditcate)
        {
            throw new NotImplementedException();
        }
    }
}