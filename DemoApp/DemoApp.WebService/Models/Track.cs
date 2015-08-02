using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApp.WebService.Models
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

        public Track(DemoApp.EfRepository.Entity.Track track)
        {
            this.AlbumId = track.AlbumId;
            this.Byte = track.Byte;
            this.Composer = track.Composer;
            this.GenreId = track.GenreId;
            this.Millisecond = track.Millisecond;
            this.Name = track.Name;
            this.TrackId = track.TrackId;
            this.UnitPrice = track.UnitPrice;
        }
    }
}