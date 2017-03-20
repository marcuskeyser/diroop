using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace ecsCore.Data.Repositories
{
    public class BaseRepository<T> where T : class, IRepository<T>
    {

        internal DbContext _context;
        internal DbSet<T> _dbSet;
        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public void Delete(string Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T item)
        {
            _dbSet.Add(item);
        }

        public List<T> SelectAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public List<T> SelectByExpression(Expression <Func<T,bool>>predicate)
        {
            List<T> results = _dbSet.AsNoTracking()
                .Where(predicate).ToList();
            return results;
        }

        public T SelectById(int id)
        {
            var lambda = Utilities.BuildLamdbaForFindByKey<T>(id);
            return _dbSet.AsNoTracking().SingleOrDefault(lambda);
        }

        public List<T> SelectAllInclude(params Expression<Func<T, object>>[] include)
        {
            return GetAllIncluding(include).ToList();
        }
        public List<T> SelectByInclude(Expression<Func<T, bool>>predicate, params Expression<Func<T, object>>[] include)
        {
            var query = GetAllIncluding(include);
            List<T> results = query.Where(predicate).ToList();
            return results;
        }

        public void Update(T item)
        {
            _dbSet.Attach(item);
            _context.Entry(item).State = EntityState.Modified;
        }
        private IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> q = _dbSet.AsNoTracking();
            return include.Aggregate (q, (current, incl) => current.Include(incl));
        }
    }
}
