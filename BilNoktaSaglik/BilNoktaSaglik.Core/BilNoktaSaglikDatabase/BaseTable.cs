using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Core.BilNoktaSaglikDatabase
{
    public abstract class BaseTable
    {
        public DateTime CreateDate{ get; set; }
        public bool IsActive { get; set; }

    }
}
