using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.DependencyInjection
{
    public class EmployeeBLL_MethodInjection
    {
        public List<Employee> GetAllEmployees(IEmployeeDAL employeeDAL)
        {
            return employeeDAL.GetAllEmployees();
        }
    }
}
