﻿using BilNoktaSaglik.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;

namespace BilNoktaSaglik.Repository.Repositories
{
    public class RulesRepository : Repository<Rules>, IRulesRepository
    {
        public RulesRepository(BilNoktaSaglikDB bilNoktaSaglikDB) : base(bilNoktaSaglikDB)
        {
        
        }

        public List<Rules> RuleList(int ruleId)
        {
            var list = _bilNoktaSaglikDB.Rules.Where(k => k.RulesId == ruleId).ToList();
            var list2 = GetAllTableWithCase(k=>k.RulesId == ruleId);   

            return list2;
        }
    }
}
