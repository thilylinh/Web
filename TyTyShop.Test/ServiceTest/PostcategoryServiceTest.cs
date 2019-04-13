using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Data.Reponsitories;
using TyTyShop.Model.Models;
using TyTyShop.Service;

namespace TyTyShop.Test.ServiceTest
{
    [TestClass]
    public class PostcategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<UnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _categoryService;
        private List<Postcategory> _listCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<UnitOfWork>();
            _categoryService = new PostCategoyService(_mockRepository.Object, _mockUnitOfWork.Object);
            _listCategory = new List<Postcategory>()
            {
                new Postcategory() {ID=1,Name="DM1",Status=true},
                new Postcategory() {ID=2,Name="DM2",Status=true},
                new Postcategory() {ID=3,Name="DM3",Status=true},
            };
        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //setup method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listCategory);
            // call action
            var result = _categoryService.GetAll() as List<Postcategory>;
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {
            Postcategory postcategory = new Postcategory();
            //int id = 1;
            postcategory.Name = "Test";
            postcategory.Alias = "Test";
            postcategory.Status = true;

            _mockRepository.Setup(m => m.Add(postcategory)).Returns((Postcategory p) =>
              {
                  p.ID = 1;
                  return p;
              });
            var result = _categoryService.Add(postcategory);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}