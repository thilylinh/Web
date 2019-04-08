using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface IPageRepository
    {
    }

    public class PageRepository : RepositoryBase<Pages>, IPageRepository
    {
        public PageRepository(Dbfactory dbfactory) : base(dbfactory)
        {
        }
    }
}