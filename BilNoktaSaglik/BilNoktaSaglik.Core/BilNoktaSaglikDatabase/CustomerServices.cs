using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Core.BilNoktaSaglikDatabase
{
    public class CustomerServices:BaseTable
    {
        public int CustomerServicesId { get; set; }
        public int CustomerId { get; set; }
        public int ServiceId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
