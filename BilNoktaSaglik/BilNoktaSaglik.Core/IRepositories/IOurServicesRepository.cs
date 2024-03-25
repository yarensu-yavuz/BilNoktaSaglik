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
        OurServices OurServiceIsActive(int OurServiceIs);
        List<OurServices> OurServicesIsActive(bool active);
    }
}
