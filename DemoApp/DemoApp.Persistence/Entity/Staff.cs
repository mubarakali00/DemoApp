using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Persistence.Entity
{
    public class Staff
    {
        public int StaffId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int AddressId { get; set; }

        public string Email { get; set; }

        public int StoreId { get; set; }

        public bool Active { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public DateTime LastUpdated { get; set; }

        public byte[] Picture { get; set; }
    }
}
