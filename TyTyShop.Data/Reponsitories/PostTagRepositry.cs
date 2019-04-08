using System;
using System.Linq.Expressions;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface IPosttagRepository : IReponsitory<PostTag>
    {
    }

    public class PostTagRepositry : RepositoryBase<PostTag>, IPosttagRepository
    {
        public PostTagRepositry(Dbfactory dbfactory) : base(dbfactory)
        {
        }

        public bool CheckContaints(Expression<Func<PostTag, bool>> preditcate)
        {
            throw new NotImplementedException();
        }
    }
}