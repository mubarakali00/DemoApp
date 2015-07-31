using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Persistence.Repository
{
    public class RepositoryService<T> : IGenericRepository<T> where T : class
    {
        private IDbContext _context;

        private IDbSet<T> _entity
        {
            get { return this._context.Set<T>(); }
        }

        public RepositoryService(IDbContext context)
        {
            this._context = context;
        }

        public IQueryable<T> GetAll()
        {
            return _entity.AsQueryable();
        }

        public T GetById(object id)
        {
            return _entity.Find(id);
        }

        public void Insert(T entity)
        {
            _entity.Add(entity);
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            this._context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _entity.Remove(entity);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this._context != null)
                {
                    this._context.Dispose();
                    this._context = null;
                }
            }
        }
    }
}
