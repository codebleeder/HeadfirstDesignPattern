using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.DependencyInjection
{
    public class EmployeeBLL
    {
        public List<Employee> GetAllEmployees()
        {
            var employeeDAL = new EmployeeDAL();
            return employeeDAL.GetAllEmployees(); // there is dependency on DAL class - this is tight coupling
        }
    }
}
