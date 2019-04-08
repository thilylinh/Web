using System;
using System.Linq;
using System.Linq.Expressions;

namespace TyTyShop.Data.Infrastructure
{
    public interface IReponsitory<T> where T : class
    {
        //Marks an entity as new
        void Add(T entity);

        //Marks an entity as modified
        void Update(T entity);

        //Marks an entity to be remove
        void Delete(T entity);
        void Delete(int id);
        //delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);

        //get an entity by int id
        T GetSingleById(int id);

        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IQueryable<T> GetAll(string[] includes = null);

        IQueryable<T> GetMulti(Expression<Func<T, bool>> preditcate, string[] includes = null);

        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);
         
        bool CheckContaints(Expression<Func<T, bool>> preditcate);
    }
}