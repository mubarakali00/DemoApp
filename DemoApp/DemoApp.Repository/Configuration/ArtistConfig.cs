using DemoApp.EfRepository.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.EfRepository.Configuration
{
    public class ArtistConfig : EntityTypeConfiguration<Artist>
    {
        public ArtistConfig()
        {
            this.ToTable("Artist", "public");
            this.HasKey(a => a.ArtistId);

            Property(a => a.ArtistId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(a => a.ArtistName)
                .HasColumnName("Name");
        }
    }
}
