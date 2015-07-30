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
    public class CategoryConfig : EntityTypeConfiguration<Category>
    {
        public CategoryConfig()
        {
            ToTable("category");

            Property(c => c.CategoryId)
                .HasColumnName("category_id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Name)
                .HasColumnName("name")
                .HasMaxLength(25)
                .IsRequired();

            Property(c => c.LastUpdated)
                .HasColumnName("last_updated")
                .IsOptional();

        }
    }
}
