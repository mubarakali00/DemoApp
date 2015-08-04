using DemoApp.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Repository.Configuration
{
    public class AlbumConfig : EntityTypeConfiguration<Album>
    {
        public AlbumConfig()
        {
            this.ToTable("Album", "public");
            this.HasKey(a => a.AlbumId);

            Property(a => a.AlbumTitle)
                .HasColumnName("Title");

            this.HasRequired(a => a.Track)
                .WithRequiredDependent(a => a.Album);
                
        }
    }
}
