using DemoApp.Repository.Context;
using DemoApp.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Repository.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private IUnitOfWork _context;

        private IDbSet<T> _entity
        {
            get { return this._context.Set<T>(); }
        }

        public GenericRepository(IUnitOfWork unitOfWork)
        {
            this._context = unitOfWork;
        }

        public IQueryable<T> GetAll()
        {
            return _entity.ToList().AsQueryable();
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
                throw new ArgumentNullException("_entity");


            this._context.Save();
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
