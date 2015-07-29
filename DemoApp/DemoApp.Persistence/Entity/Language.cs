using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Persistence.Entity
{
    public class Language
    {
        public int LanguageId { get; set; }

        public string Name { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
