using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.DependencyInjection
{
    // using dependency injection
    public class EmployeeBLL_ConstructorInjection
    {
        public IEmployeeDAL EmployeeDALObj { get; set; }
        public EmployeeBLL_ConstructorInjection(IEmployeeDAL employeeDALObj)
        {
            EmployeeDALObj = employeeDALObj;
        }
        public List<Employee> GetAllEmployees()
        {
            return EmployeeDALObj.GetAllEmployees();
        }
    }
}
