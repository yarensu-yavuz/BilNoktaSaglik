using BilNoktaSaglik.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;

namespace BilNoktaSaglik.Repository.Repositories
{
    public class RulesRepository : Repository<RulesRepository>
    {
        public RulesRepository(BilNoktaSaglikDB bilNoktaSaglikDB) : base(bilNoktaSaglikDB)
        {
        
        }

    }
}
