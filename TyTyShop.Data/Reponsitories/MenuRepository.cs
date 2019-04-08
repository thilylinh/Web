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
    public interface IMenuRepository:IReponsitory<Menu>
    {

    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository 
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public bool CheckContaints(Expression<Func<Menu, bool>> preditcate)
        {
            throw new NotImplementedException();
        }
    }
}
