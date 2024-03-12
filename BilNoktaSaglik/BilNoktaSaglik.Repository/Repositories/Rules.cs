using BilNoktaSaglik.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;

namespace BilNoktaSaglik.Repository.Repositories
{
    public class Rules : Repository<Rules>
    {
        public Rules(BilNoktaSaglikDB bilNoktaSaglikDB) : base(bilNoktaSaglikDB)
        {
        
        }

    }
}
