using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Persistence.Entity
{
    public class Address
    {
        public int AddressId { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string District { get; set; }

        public int CityId { get; set; }

        public string PostCode { get; set; }

        public string Phone { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
