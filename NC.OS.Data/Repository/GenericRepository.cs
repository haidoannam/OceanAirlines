using NC.OS.Data.Context;
using NC.OS.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private DbContext _context;
        private DbSet<T> _dbSet;
        public GenericRepository(OceanAirlinesContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T entity)
        {

            _dbSet.Add(entity);
        }

        public void Delete(string id)
        {
            //_dbSet.FirstOrDefault(x => x.Id == id).Remove = true;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate).AsQueryable();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null)
                return _dbSet.AsQueryable();
            return _dbSet.Where(predicate).AsQueryable();
        }

        //public T GetById(string id)
        //{
        //    return _dbSet.FirstOrDefault(x => x.Id == id );
        //}

        public void Update(T entity)
        {
            //_dbSet.u(entity);
           
        }
        //public PagedCollection<T> Paging(int? page, int? pageSize, Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        //{
        //    var currPage = page.GetValueOrDefault(1);
        //    var currPageSize = pageSize.GetValueOrDefault(10);

        //    //var paged = collection.Find(_ => true).Skip(currPage * currPageSize).Limit(currPageSize).ToEnumerable();
        //    IQueryable<T> query = _dbSet.AsQueryable();
        //    IQueryable<T> order = query;

        //    if (filter != null)
        //    {
        //        query = query.Where(filter);
        //        order = query;
        //    }

        //    if (orderBy != null)
        //    {
        //        order = orderBy(query);
        //    }
        //    else
        //    {
        //        order = query;
        //    }

        //    var totalCount = query.Count();
        //    return new PagedCollection<T>
        //    {
        //        TotalCount = totalCount,
        //        TotalPages = (int)Math.Ceiling((double)((float)totalCount / currPageSize)),
        //        Items = order.Skip(((currPage - 1) < 0 ? 0 : (currPage - 1)) * currPageSize).Take(currPageSize).ToArray()
        //    };


        //}
    }
}
