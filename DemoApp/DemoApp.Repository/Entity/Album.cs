using DemoApp.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Repository.Entity
{
    public class Album
    {
        public int AlbumId { get; set; }

        public string AlbumTitle { get; set; }

        public int ArtistId { get; set; }

        public virtual Track Track { get; set; }
    }
}
