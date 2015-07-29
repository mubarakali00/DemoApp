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
        
        public int LanguageId { get; set; }

        public int Length { get; set; }

        public string Rating { get; set; }

        public decimal RentalRate { get; set; }

        public string Title { get; set; }

    }
}
