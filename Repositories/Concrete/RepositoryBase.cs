using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concrete
{
    public abstract class RepositoryBase<T> : IRepositortBase<T> where T : class
    {
        protected readonly FoodContext _context;

        public RepositoryBase(FoodContext context)
        {
            _context = context;
        }
        public void Create(T entity) => _context.Set<T>().Add(entity);

        public void Delete(T entity) => _context.Set<T>().Remove(entity);

        public T Get(Expression<Func<T, bool>> filter = null) => _context.Set<T>().AsNoTracking().SingleOrDefault(filter);

        public IQueryable<T> GetList(Expression<Func<T, bool>> filter = null) =>
               filter != null
            ? _context.Set<T>().Where(filter).AsNoTracking()
            : _context.Set<T>().AsNoTracking();

        public void Update(T entity) => _context.Set<T>().Update(entity);
    }
}
