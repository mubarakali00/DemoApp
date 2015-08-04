using DemoApp.Repository.Entity;
using DemoApp.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Repository.Repository
{
    public interface ITrackRepository : IGenericRepository<Track>
    {
        IQueryable<Track> GetTrackWithAlbum();
    }
}
