using DemoApp.Repository.Context;
using DemoApp.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Repository.Repository
{
    public class AlbumRepository : GenericRepository<Album>, IAlbumRepository
    {
        private IUnitOfWork _context;
        private IDbSet<Album> _entity;

        public AlbumRepository(IUnitOfWork context) : base(context)
        {
            this._context = context;
            this._entity = _context.Set<Album>();
        }

        public IQueryable<Album> GetAlbumWithTrack()
        {
            var list = _entity.Include(a => a.Track).ToList().AsQueryable();
            return list;
        }
    }
}
