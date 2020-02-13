using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.DependencyInjection
{
    public class EmployeeDAL2 : IEmployeeDAL
    {
        public List<Employee> GetAllEmployees()
        {
            var employees = new List<Employee> {
                new Employee(1, "Johnny", "Software Development"),
                new Employee(2, "Liam", "Human Resources"),
                new Employee(3, "Ferguson", "Facilities"),
            };
            return employees;
        }
    }
}
