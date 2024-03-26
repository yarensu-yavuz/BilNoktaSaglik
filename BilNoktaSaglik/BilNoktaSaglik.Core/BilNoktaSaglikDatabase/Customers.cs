using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Core.BilNoktaSaglikDatabase
{
    public class Customers
    {
        public int CustomersId { get; set; }

        public string CustomersName { get; set; }

        public string CustomersSurname { get; set; }
        public string CustomersDescription { get; set; }

        public int PassportNumber { get; set; }

        public int Age { get; set; }
        public string Gender { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }

        public DateTime TREnterDate { get; set; } //DateTime doğru oldu mu?
        public bool IsAccomodation { get; set; }
        public string ExtraDiscomfort { get; set; }
        public DateTime AddedTime { get; set; }
        public int PhoneNumber { get; set; }

        public int CountriesId { get; set; }//Foreign Key olacaktı.
        public Countries Countries { get; set; }
    }
}
