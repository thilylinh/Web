using System;
using System.Linq.Expressions;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface IPageRepository : IReponsitory<Pages>
    {
    }

    public class PageRepository : RepositoryBase<Pages>, IPageRepository
    {
        public PageRepository(Dbfactory dbfactory) : base(dbfactory)
        {
        }

        public bool CheckContaints(Expression<Func<Pages, bool>> preditcate)
        {
            throw new NotImplementedException();
        }
    }
}