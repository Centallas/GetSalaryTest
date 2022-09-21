using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Employees
{
    public class EmployeeFactory : IEmployeeFactory
    {
          public int GetSalaryEmployee(string role, int workedHours)
        {
            switch (role)
            {
                case "regular":
                    return workedHours * 10;
                case "assistant":
                    return workedHours * 12;
                case "manager":
                    return workedHours * 15;
                default:
                    return 0;

            }
        }
    }
}