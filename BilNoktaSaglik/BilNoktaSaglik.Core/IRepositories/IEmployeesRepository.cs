﻿using BilNoktaSaglik.Core.BilNoktaSaglikDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilNoktaSaglik.Core.IRepositories
{
    public interface IEmployeesRepository : IRepository<Employees>
    {
        List<Employees> EmployeesActive(bool active);

    }
}
