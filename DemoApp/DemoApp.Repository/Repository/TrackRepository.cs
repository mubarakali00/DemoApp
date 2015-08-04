
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
    public class TrackRepository : GenericRepository<Track>, ITrackRepository
    {
        private IUnitOfWork _context;
        private IDbSet<Track> _entity;

        public TrackRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._context = unitOfWork;
            this._entity = _context.Set<Track>();
        }

        public IQueryable<Track> GetTrackWithAlbum()
        {
            var list = _entity.Include(t => t.Album).ToList().AsQueryable();
            return list;
        }
    }
}
