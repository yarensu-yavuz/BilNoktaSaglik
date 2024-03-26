using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;
using BilNoktaSaglik.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Repository.Repositories
{
    public class OurServicesRepository : Repository<OurServices>,IOurServicesRepository
    {
        public OurServicesRepository(BilNoktaSaglikDB bilNoktaSaglikDB) : base(bilNoktaSaglikDB)
        {

        }

        public List<OurServices> CustomerService(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
