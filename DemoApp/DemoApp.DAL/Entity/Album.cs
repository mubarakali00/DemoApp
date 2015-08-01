using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.DAL.Entity
{
    [Table(Schema = "public", Name = "Album")]
    public class Album
    {
        [PrimaryKey, NotNull]
        public int AlbumId { get; set; } // integer
        [Column, NotNull]
        public string Title { get; set; } // character varying(160)
        [Column, NotNull]
        public int ArtistId { get; set; } // integer

        #region Associations

        [Association(ThisKey = "ArtistId", OtherKey = "ArtistId", CanBeNull = false, KeyName = "FK_AlbumArtistId", BackReferenceName = "AlbumArtistIds")]
        public Artist AlbumArtistId { get; set; }

        #endregion
    }
}
