using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Persistence.Entity
{
    public class Film
    {
        public int FilmId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseYear { get; set; }

        public int LanguageId { get; set; }

        public int RentalDuration { get; set; }

        public decimal RentalRate { get; set; }

        public int Length { get; set; }

        public decimal ReplacementCost { get; set; }

        public string RatingMpaaRating { get; set; }

        public DateTime LastUpdated { get; set; }

        public string SpecialFeatures { get; set; }

        public virtual FilmActor FilmActor { get; set; }

        public virtual List<Language> Languages { get; set; }

        public virtual FilmCategory FilmCategory { get; set; }

        public virtual Inventory Inventory { get; set; }
    }
}
