using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Core.IRepositories
{
    public interface ICountriesRepository:IRepository<Countries>
    {
        Countries CountryIsActive(int CountryIs);
        List<Countries> CountriesActive(bool active);
    }
}
