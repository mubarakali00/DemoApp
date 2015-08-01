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
    public class FilmConfig : EntityTypeConfiguration<Film>
    {
        public FilmConfig()
        {
            ToTable("film", "public");

            Property(f => f.FilmId)
                .HasColumnName("film_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(f => f.LanguageId)
                .HasColumnName("language_id");


            HasMany(f => f.Languages)
                .WithRequired(l => l.Film)
                .HasForeignKey(l => l.LanguageId);


        }
    }
}
