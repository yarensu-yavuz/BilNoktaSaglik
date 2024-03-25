using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Core.IRepositories
{
    public interface IUsersRepository:IRepository<Users>
    {

        //interface sadece imtlement için kodlanır, method gövdesi olmaz
        //bütün Crud işlemleri IRepository den gelecek

        Users UserIsActive(int UserIs);
        List<Users> UsersIsActive(bool active);
        //ʕ܍ᴥ܍ʔ SORU:Hocam burada ne oluyor?ʕ܍ᴥ܍ʔ


    }
}
