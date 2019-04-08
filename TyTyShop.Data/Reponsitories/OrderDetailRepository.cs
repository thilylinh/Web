using System;
using System.Linq.Expressions;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface IOrderDetailRepository : IReponsitory<OrderDetail>
    {
    }

    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public bool CheckContaints(Expression<Func<OrderDetail, bool>> preditcate)
        {
            throw new NotImplementedException();
        }
    }
}