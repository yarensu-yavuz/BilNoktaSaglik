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

        public List<Users> UsersIsActive(bool active)
        {
            throw new NotImplementedException();
        }
    }
}
