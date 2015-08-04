using DemoApp.Repository.Context;
using DemoApp.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Repository.Repository
{
    public class ArtistRepository : IArtistRepository
    {
        private DatabaseContext _context;

        public ArtistRepository()
        {
            this._context = new DatabaseContext();
        }

        public List<Artist> GetAll()
        {
            return _context.Artist.ToList();
        }
    }
}
