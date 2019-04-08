using TyTyShop.Data.Infrastructure;
using TyTyShop.Model.Models;

namespace TyTyShop.Data.Reponsitories
{
    public interface IPosttagRepository
    {
    }

    public class PostTagRepositry : RepositoryBase<PostTag>, IPosttagRepository
    {
        public PostTagRepositry(Dbfactory dbfactory) : base(dbfactory)
        {
        }
    }
}