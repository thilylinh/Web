using System;
using System.Linq.Expressions;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface IFooterRepository : IReponsitory<Footer>
    {
    }

    public class FooterRepository : RepositoryBase<Footer>,IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public bool CheckContaints(Expression<Func<Footer, bool>> preditcate)
        {
            throw new NotImplementedException();
        }
    }
}