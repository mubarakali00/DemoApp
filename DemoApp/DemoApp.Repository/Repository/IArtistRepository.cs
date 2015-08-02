using DemoApp.EfRepository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.EfRepository.Repository
{
    public interface IArtistRepository
    {
        List<Artist> GetAll();
    }
}
