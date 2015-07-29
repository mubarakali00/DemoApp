using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Persistence.Entity
{
    public class FilmCategory
    {
        public int FilmId { get; set; }

        public int CategoryId { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
