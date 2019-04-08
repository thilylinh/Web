using System;
using System.Linq.Expressions;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface ISlideRepostory : IReponsitory<Slide>
    {
    }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepostory
    {
        public SlideRepository(Dbfactory dbfactory) : base(dbfactory)
        {
        }

        public bool CheckContaints(Expression<Func<Slide, bool>> preditcate)
        {
            throw new NotImplementedException();
        }
    }
}