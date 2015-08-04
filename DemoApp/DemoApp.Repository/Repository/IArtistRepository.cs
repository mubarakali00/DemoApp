using DemoApp.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Repository.Repository
{
    public interface IArtistRepository
    {
        List<Artist> GetAll();
    }
}
