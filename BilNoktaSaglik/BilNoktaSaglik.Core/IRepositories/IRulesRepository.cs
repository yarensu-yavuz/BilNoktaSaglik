using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Core.IRepositories
{
    public interface IRulesRepository:IRepository<Rules>
    {
        /// <summary>
        /// Her bir Rule'de olan User'ları listeler
        /// </summary>
        /// <param name="ruleId"></param>
        /// <returns></returns>
        List<Rules> RuleList(int ruleId);
        //Admin=> Resül , Yare, Su, Helim, Yaşar
        //Persoenl=> Mehmet, Ayşe, Roj, Asur


    }
}
