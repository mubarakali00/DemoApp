using DemoApp.EfRepository.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.EfRepository.Configuration
{
    public class TrackConfig : EntityTypeConfiguration<Track>
    {
        public TrackConfig()
        {
            this.ToTable("Track", "public");
            this.HasKey(t => t.TrackId);

            Property(t => t.Millisecond)
                .HasColumnName("Milliseconds");

            Property(t => t.Byte)
                .HasColumnName("Bytes");

        }
    }
}
