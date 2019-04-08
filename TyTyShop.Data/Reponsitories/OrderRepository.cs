using System;
using System.Linq.Expressions;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface IOrderRepository: IReponsitory<Order>
    {
    }

    internal class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(Dbfactory dbfactory) : base(dbfactory)
        {
        }

        public bool CheckContaints(Expression<Func<Order, bool>> preditcate)
        {
            throw new NotImplementedException();
        }
    }
}