using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;
using BilNoktaSaglik.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Repository.Repositories
{
    public class CountriesRepository : Repository<Countries>,ICountriesRepository
    {
        public CountriesRepository(BilNoktaSaglikDB bilNoktaSaglikDB) : base(bilNoktaSaglikDB)
        {

        }

    }
}
