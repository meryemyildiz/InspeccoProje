using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccessLayer.Abstract
{
   public interface IBaseRepository<T,Id>where T:class,new()
    {
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        T GetById(Id id);
        T GetFirstOrDefault(Expression<Func<T, bool>> filter, string includeEntities = null);
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter, string includeEntities = null);
    }
}
