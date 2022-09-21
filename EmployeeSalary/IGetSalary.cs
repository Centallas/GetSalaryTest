using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public interface IGetSalary
    {
        int DoSomeRealWork(string role, int salary);
    }
}