using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CookedToFoodCore.DataAccess.Ef
{
    public abstract class EfCoreGenericRepository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _context;

        public EfCoreGenericRepository(DbContext context)
        {
            _context= context;
        }
        public void Create(T entity) => _context.Set<T>().Add(entity);

        public void Delete(T entity)=> _context.Set<T>().Remove(entity);

        public T Get(Expression<Func<T, bool>> filter = null) => _context.Set<T>().AsNoTracking().SingleOrDefault(filter);

        public List<T> GetList(Expression<Func<T, bool>> filter = null) =>
               filter == null
            ? _context.Set<T>().ToList()
            : _context.Set<T>().Where(filter).ToList();

        public void Update(T entity) => _context.Set<T>().Update(entity);
    }
}
