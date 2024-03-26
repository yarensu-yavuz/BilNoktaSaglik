using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Core.BilNoktaSaglikDatabase
{
    public class Users:BaseTable//
    {
        public int UsersId { get; set; }
        public string UserName{ get; set; }
        public string UserPassword{ get; set; }
        public int RuleId { get; set; }
        //FK işlemleri
        public Rules Rule { get; set; }
    }
}
