using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IRepository<T> where T : class
    {
        T Get(Expression<Func<T,bool>> filter = null);
        IQueryable<T> GetList(Expression<Func<T,bool>> filter = null);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
