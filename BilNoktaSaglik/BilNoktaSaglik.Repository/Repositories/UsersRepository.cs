using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;
using BilNoktaSaglik.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Repository.Repositories
{
    public class UsersRepository : Repository<Users>,IUsersRepository
    {
        public UsersRepository(BilNoktaSaglikDB bilNoktaSaglikDB) : base(bilNoktaSaglikDB)
        {
        }

        /// <summary>
        /// Aktifleri listelemek için parametre 1(true), pasifleri listelemek için 0(false) gönderilir
        /// </summary>
        /// <param name="active"></param>
        /// <returns></returns>
        public List<Users> UsersIsActive(bool active)
        {
            return GetAllTableWithCase(y => y.IsActive == active);
        }
    }
}
