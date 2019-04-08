using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;
using System.Linq;

namespace TyTyShop.Data.Reponsitories
{
    public interface IPostRepository : IReponsitory<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(Dbfactory dbfactory) : base(dbfactory)
        {

        }

        public bool CheckContaints(Expression<Func<Post, bool>> preditcate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.posts
                        join pt in DbContext.postTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status
                        orderby p.CreatedDate descending
                        select p;
            totalRow = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query;
        }
    }
}