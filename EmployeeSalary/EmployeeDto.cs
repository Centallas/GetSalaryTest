using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public EmployeeDto(int id, string name, string role)
        {
            Id = id;
            Name = name;
            Role = role;
        }

    }
}