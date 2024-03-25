using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Core.IRepositories
{
    public interface IServiceCategoriesRepository : IRepository<ServiceCategories>
    {
       ServiceCategories ServiceCategoryIsActive(int ServiceCategoryIs);
        List<ServiceCategories> ServiceCategoryIsActive(bool active);
    }
}
