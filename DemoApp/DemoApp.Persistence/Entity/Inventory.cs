using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Persistence.Entity
{
    public class Inventory
    {
        public int InventoryId { get; set; }

        public int FilmId { get; set; }

        public int StoreId { get; set; }

        public DateTime LastUpdated { get; set; }

        public virtual List<Film> Films { get; set; }
    }
}
