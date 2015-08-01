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
    public class InventoryConfig : EntityTypeConfiguration<Inventory>
    {
        public InventoryConfig()
        {
            ToTable("inventory", "public");

            Property(i => i.InventoryId)
                .HasColumnName("inventory_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(i => i.FilmId)
                .HasColumnName("film_id")
                .IsRequired();

            Property(i => i.StoreId)
                .HasColumnName("store_id")
                .IsRequired();

            Property(i => i.LastUpdated)
                .HasColumnName("last_update")
                .IsOptional();

            HasMany(i => i.Films)
                .WithRequired(f => f.Inventory)
                .HasForeignKey(f => f.FilmId);

        }
    }
}
