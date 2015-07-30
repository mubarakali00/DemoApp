using DemoApp.Persistence.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Persistence.Configuration
{
    public class FilmCategoryConfig : EntityTypeConfiguration<FilmCategory>
    {
        public FilmCategoryConfig()
        {
            ToTable("film_category");

            Property(f => f.CategoryId)
                .HasColumnName("category_id")
                .IsRequired();

            Property(f => f.FilmId)
                .HasColumnName("film_id")
                .IsRequired();

            Property(f => f.LastUpdated)
                .HasColumnName("last_updated")
                .IsOptional();

            HasMany(f => f.Categories)
                .WithRequired(c => c.CategoryFilm)
                .HasForeignKey(c => c.CategoryId);

            HasMany(f => f.Films)
                .WithRequired(x => x.FilmCategory)
                .HasForeignKey(x => x.FilmId);
        }
    }
}
