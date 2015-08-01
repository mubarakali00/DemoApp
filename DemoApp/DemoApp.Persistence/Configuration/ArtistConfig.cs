using DemoApp.Persistence.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Persistence.Configuration
{
    public class ArtistConfig : EntityTypeConfiguration<Artist>
    {
        public ArtistConfig()
        {
            this.ToTable("artist");

            Property(a => a.ArtistId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(a => a.ArtistName)
                .HasColumnName("Name");

        }
    }
}
