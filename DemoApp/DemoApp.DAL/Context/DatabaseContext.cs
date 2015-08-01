using DemoApp.DAL.Entity;
using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider.PostgreSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.DAL.Context
{
    public class DatabaseContext : DataConnection
    {
        public DatabaseContext(string connectionString)
            : base(connectionString)
        {

        }

        public ITable<Album> Albums { get { return this.GetTable<Album>(); } }
        public ITable<Artist> Artists { get { return this.GetTable<Artist>(); } }
    }
}
