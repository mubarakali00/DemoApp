using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Persistence.Entity
{
    public class Country
    {
        public int CountryId { get; set; }

        public string Country { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
