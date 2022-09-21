using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class SalaryService : IGetSalary
    {
        private readonly IEmployeeService _employeeService;

        public SalaryService(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public int DoSomeRealWork(string role, int salary)
        {
            // for (int i = 0; i < 10; i++)
            // {
               return _employeeService.DoThing(role, salary);
            // }

        }
    }

}