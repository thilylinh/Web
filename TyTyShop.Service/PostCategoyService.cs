using System.Collections.Generic;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Data.Reponsitories;
using TyTyShop.Model.Models;

namespace TyTyShop.Service
{
    public interface IPostCategoryService
    {
        Postcategory Add(Postcategory postcategory);

        void Update(Postcategory postcategory);

        Postcategory Delete(int id);

        IEnumerable<Postcategory> GetAll();

        IEnumerable<Postcategory> GetAllByParentId(int parentId);

        Postcategory GetById(int id);

        void Save();
    }

    public class PostCategoyService : IPostCategoryService
    {
        private IPostCategoryRepository _postCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public PostCategoyService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public Postcategory Add(Postcategory postcategory)
        {
           return _postCategoryRepository.Add(postcategory);
        }

        public Postcategory Delete(int id)
        {
            return _postCategoryRepository.Delete(id);
        }

        public IEnumerable<Postcategory> GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        public IEnumerable<Postcategory> GetAllByParentId(int parentId)
        {
            return _postCategoryRepository.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public Postcategory GetById(int id)
        {
            return _postCategoryRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(Postcategory postcategory)
        {
            _postCategoryRepository.Update(postcategory);
        }
    }
}