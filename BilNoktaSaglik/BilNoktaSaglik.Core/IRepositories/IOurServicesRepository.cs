using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BilNoktaSaglik.Core.IRepositories
{
    public interface IOurServicesRepository : IRepository <OurServices>
    {
        List<OurServices> CustomerService(int customerId);

    }
}
