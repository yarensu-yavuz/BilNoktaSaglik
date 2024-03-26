using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Core.BilNoktaSaglikDatabase
{
    public class ServiceCategories
    {

        public int ServicesCategoriesId { get; set; }
        public string ServicesCategoriesName { get; set; }
        public string CategoriesDescription { get; set; }
        public DateTime AddedTime { get; set; }

    }
}
