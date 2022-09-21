using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;

namespace EmployeeSalary
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeFactory _employeeFactory;

        public EmployeeService(IEmployeeFactory employeeFactory)
        {
            _employeeFactory = employeeFactory;
            // _logger = loggerFactory.CreateLogger<EmployeeService>();
        }

        public int DoThing(string role, int salary)
        {
            // _logger.LogInformation($"Doing the thing {number}");
            return _employeeFactory.GetSalaryEmployee(role, salary);
        }

    }
}