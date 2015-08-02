using DemoApp.EfRepository.Configuration;
using DemoApp.EfRepository.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.EfRepository.Context
{
    public class DatabaseContext : DbContext, IUnitOfWork
    {
        public DatabaseContext()
            : base(ConfigurationManager.ConnectionStrings["chinook-local"].Name)
        {
            Database.SetInitializer<DatabaseContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new ArtistConfig());
            //modelBuilder.Configurations.Add(new TrackConfig());

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            .Where(type => !String.IsNullOrEmpty(type.Namespace))
            .Where(type => type.BaseType != null && type.BaseType.IsGenericType &&
               type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            base.OnModelCreating(modelBuilder);
        }

        public IDbSet<Artist> Artist { get; set; }
        public IDbSet<Track> Track { get; set; }

        public int Save()
        {
            return SaveChanges();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
