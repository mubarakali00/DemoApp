
using DemoApp.EfRepository.Context;
using DemoApp.EfRepository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.EfRepository.Repository
{
    public class TrackRepository : GenericRepository<Track>, ITrackRepository
    {
        private IUnitOfWork _context;

        public TrackRepository(DatabaseContext unitOfWork) : base(unitOfWork)
        {
            this._context = unitOfWork;
        }

    }
}
