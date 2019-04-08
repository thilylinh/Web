using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TyTyShop.Data.Infrastructure;
using TyTyShop.Data.Reponsitories;
using TyTyShop.Model.Models;

namespace TyTyShop.Service
{
    public interface IPostCategoryService
    {
        void Add(Postcategory postcategory);
        void Update(Postcategory postcategory);
        void Delete(int id);
        IEnumerable<Postcategory> GetAll();
        IEnumerable<Postcategory> GetAllByParentId(int parentId);
        Postcategory GetById(int id);
    }
    public class PostCategoyService : IPostCategoryService
    {
        IPostCategoryRepository _postCategoryRepository;
        IUnitOfWork _unitOfWork;
        public PostCategoyService(IPostCategoryRepository postCategoryRepository,IUnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Postcategory postcategory)
        {
            _postCategoryRepository.Add(postcategory);
        }

        public void Delete(int id)
        {
            _postCategoryRepository.Delete(id);
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

        public void Update(Postcategory postcategory)
        {
            _postCategoryRepository.Update(postcategory);
        }
    }
}
