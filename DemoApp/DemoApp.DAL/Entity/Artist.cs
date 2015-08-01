using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.DAL.Entity
{
    [Table(Schema = "public", Name = "Artist")]
    public class Artist
    {
        [PrimaryKey, NotNull]
        public int ArtistId { get; set; } // integer

        [Column, Nullable]
        public string Name { get; set; } // character varying(120)

        #region Associations

        [Association(ThisKey = "ArtistId", OtherKey = "ArtistId", CanBeNull = true, IsBackReference = true)]
        public IEnumerable<Album> AlbumArtistIds { get; set; }

        #endregion
    }
}
