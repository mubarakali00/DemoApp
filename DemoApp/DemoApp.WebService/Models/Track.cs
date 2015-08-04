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

        public Album Album { get; set; }

        public Track(DemoApp.Repository.Entity.Track track)
        {
            this.AlbumId = track.AlbumId;
            this.Byte = track.Byte;
            this.Composer = track.Composer;
            this.GenreId = track.GenreId;
            this.Millisecond = track.Millisecond;
            this.Name = track.Name;
            this.TrackId = track.TrackId;
            this.UnitPrice = track.UnitPrice;
            this.Album = track.Album != null ? getAlbum(track.Album) : new Album();
        }

        private Album getAlbum(DemoApp.Repository.Entity.Album album)
        {
            Album _album = new Album
            {
                AlbumId = album.AlbumId,
                ArtistId = album.ArtistId,
                Title = album.AlbumTitle
            };
            return _album;
        }
    }
}