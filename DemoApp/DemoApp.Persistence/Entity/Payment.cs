using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Persistence.Entity
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public int CustomerId { get; set; }

        public int StaffId { get; set; }

        public int RentalId { get; set; }

        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}
