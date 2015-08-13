using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Linq2DbRepository.DataContext
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();

        ITable<TEntity> GetEntity<TEntity>() where TEntity:class;
    }
}
