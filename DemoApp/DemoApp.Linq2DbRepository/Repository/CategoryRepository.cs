using DemoApp.Linq2DbRepository.DataContext;
using DemoApp.Linq2DbRepository.Entity;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Linq2DbRepository.Repository
{
    public class CategoryRepository : DatabaseContext, IGenericRepository<Category>
    {
        private IUnitOfWork _context;
        private ITable<Category> _entity;

        public CategoryRepository(IUnitOfWork context)
        {
            this._context = context;
            this._entity = _context.GetEntity<Category>();
        }

        public IQueryable<Category> GetAll()
        {
            return _entity.ToList().AsQueryable();
        }
    }
}
