using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Core.IRepositories
{
    public interface ICustomersRepository:IRepository<Customers>
    {
        Customers CustomerIsActive(int CustomerIs);
        List<Customers> CustomersActive(bool active);
    }
}
