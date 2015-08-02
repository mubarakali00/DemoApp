using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.EfRepository.Entity
{
    public class Track
    {
        public int TrackId { get; set; }

        public string Name { get; set; }

        public int AlbumId { get; set; }

        public int GenreId { get; set; }

        public string Composer { get; set; }

        public int Millisecond { get; set; }

        public int Byte { get; set; }

        public decimal UnitPrice { get; set; }

    }
}
