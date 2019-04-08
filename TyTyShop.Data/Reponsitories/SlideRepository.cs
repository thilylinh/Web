using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface ISlideRepostory
    {
    }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepostory
    {
        public SlideRepository(Dbfactory dbfactory) : base(dbfactory)
        {
        }
    }
}