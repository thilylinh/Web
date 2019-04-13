using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Data.Reponsitories;
using TyTyShop.Model.Models;

namespace TyTyShop.Test.RepositoryTest
{
    [TestClass]
    public class PostCatelogyRepositoryTest
    {
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new Dbfactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }
        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(1, list.Count);
        }
        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            Postcategory postcategory = new Postcategory();
            postcategory.Name = "test category";
            postcategory.Alias = "Test-category";
            postcategory.Status = true;

            var result = objRepository.Add(postcategory);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.ID);
        }
    }
}