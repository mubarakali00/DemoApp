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
    public class ActorConfig : EntityTypeConfiguration<Actor>
    {
        public ActorConfig()
        {
           
            ToTable("actor", "public");

               Property(a => a.ActorId)
                   .HasColumnName("actor_id")
                   .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                Property(a => a.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(45)
                    .IsRequired();

                Property(a => a.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(45)
                    .IsOptional();

                Property(a => a.LastUpdated)
                    .HasColumnName("last_updated")
                    .IsOptional();
            
        }
    }
}
