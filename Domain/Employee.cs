using System;

namespace Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

         public Employee(int id, string name, string role)
        {
            Id = id;
            Name = name;
            Role = role;
        }
    }
}