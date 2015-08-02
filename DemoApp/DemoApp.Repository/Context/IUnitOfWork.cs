using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.EfRepository.Context
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
