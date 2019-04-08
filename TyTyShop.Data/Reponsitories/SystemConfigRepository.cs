using System;
using System.Linq.Expressions;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface ISystemConfigRepository : IReponsitory<SystemConfig>
    {
    }

    public class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfigRepository
    {
        public SystemConfigRepository(Dbfactory dbfactory) : base(dbfactory)
        {
        }

        public bool CheckContaints(Expression<Func<SystemConfig, bool>> preditcate)
        {
            throw new NotImplementedException();
        }
    }
}