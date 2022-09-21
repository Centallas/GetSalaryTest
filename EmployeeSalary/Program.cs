using System;
using System.Collections.Generic;
using Application.Employees;
using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;

namespace EmployeeSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello slave Employee's World!");

            IGetSalary serviceProvider = ConfigureServices();
            List<EmployeeDto> employees = GetEmployeeData();

            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee: {employee.Id} - {employee.Name}");
                var role = employee.Role;
                Console.WriteLine($"Salary: {serviceProvider.DoSomeRealWork(role, 40)}");

            }
        }

        private static IGetSalary ConfigureServices()
        {
            var services = new ServiceCollection()
            .AddSingleton<IEmployeeService, EmployeeService>()
            .AddSingleton<IGetSalary, SalaryService>()
            .AddSingleton<IEmployeeFactory, EmployeeFactory>();

            var container = new Container();
            container.Configure(config =>
            {
                // Register stuff in container, using the StructureMap APIs...
                config.Scan(_ =>
                {
                    _.AssemblyContainingType(typeof(Program));
                    _.WithDefaultConventions();
                });
                // Populate the container using the service collection
                config.Populate(services);

            });

            //do the hard work here
            var serviceProvider = container.GetInstance<IGetSalary>();
            return serviceProvider;
        }
        //Here the source data could be change easy
        private static List<EmployeeDto> GetEmployeeData()
        {
            return new List<EmployeeDto>()
            {
                new EmployeeDto(1, "Olive Thompson", "regular"),
                new EmployeeDto(2, "Peter Mccoy", "assistant"),
                new EmployeeDto(3, "Beatriz Blackmore", "manager")
            };
        }
    }
}
