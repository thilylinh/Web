using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface IOrderRepository
    {
    }

    internal class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(Dbfactory dbfactory) : base(dbfactory)
        {
        }
    }
}