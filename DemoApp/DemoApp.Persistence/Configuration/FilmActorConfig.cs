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
    public class FilmActorConfig : EntityTypeConfiguration<FilmActor>
    {
        public FilmActorConfig()
        {
            ToTable("film_actor");

            Property(f => f.ActorId)
             .HasColumnName("actor_id")
             .IsRequired();

            Property(f => f.FilmId)
                .HasColumnName("film_id")
                .IsRequired();

            Property(f => f.LastUpdated)
                .HasColumnName("last_updated")
                .IsOptional();

            HasMany(a => a.Actors)
                .WithRequired(f => f.ActorFilm)
                .HasForeignKey(f => f.ActorId);

            HasMany(a => a.Films)
                .WithRequired(f => f.FilmActor)
                .HasForeignKey(f => f.FilmId);

        }
    }
}
