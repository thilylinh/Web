using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface IMenuGroupRepository : IReponsitory<MenuGroup>
    {

    }
    public class MenuGroupRepository : RepositoryBase<MenuGroup>,IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public bool CheckContaints(Expression<Func<MenuGroup, bool>> preditcate)
        {
            throw new NotImplementedException();
        }
    }
}
