using DemoApp.Persistence.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Persistence
{
    public class DatabaseChinookContext : DbContext, IDbContext
    {
        public DatabaseChinookContext() : base("chinook")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArtistConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
