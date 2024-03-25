using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Repository.Repositories
{
    public class ServiceCategoriesRepository : Repository<ServiceCategoriesRepository>
    {
        public ServiceCategoriesRepository(BilNoktaSaglikDB bilNoktaSaglikDB) : base(bilNoktaSaglikDB)
        {

        }

    }
}
