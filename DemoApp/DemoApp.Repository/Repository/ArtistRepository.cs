using DemoApp.EfRepository.Context;
using DemoApp.EfRepository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.EfRepository.Repository
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
