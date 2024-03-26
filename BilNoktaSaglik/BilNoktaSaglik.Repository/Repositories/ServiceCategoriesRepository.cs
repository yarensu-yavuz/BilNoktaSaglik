using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;
using BilNoktaSaglik.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Repository.Repositories
{
    public class ServiceCategoriesRepository : Repository<ServiceCategories>,IServiceCategoriesRepository
    { 
        public ServiceCategoriesRepository(BilNoktaSaglikDB bilNoktaSaglikDB) : base(bilNoktaSaglikDB)
        {

        }

        public List<ServiceCategories> ServiceCategoryIsActive(bool active)
        {
            throw new NotImplementedException();
        }
    }
}
