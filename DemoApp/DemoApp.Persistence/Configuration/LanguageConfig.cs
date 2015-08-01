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
    public class LanguageConfig : EntityTypeConfiguration<Language>
    {
        public LanguageConfig()
        {
            ToTable("language", "public");

            Property(l => l.LanguageId)
                .HasColumnName("language_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(l => l.Name)
                .HasColumnName("name")
                .HasMaxLength(20)
                .IsRequired();

            Property(l => l.LastUpdated)
                .HasColumnName("last_updated")
                .IsOptional();

        }
    }
}
