using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.DependencyInjection
{
    public class EmployeeBLL_PropertyInjection
    {
        public IEmployeeDAL EmployeeDALObj { get; set; }
        public List<Employee> GetAllEmployees()
        {
            if (EmployeeDALObj == null)
            {
                throw new NullReferenceException("Please set EmployeeDAL for this instance");
            }
            return EmployeeDALObj.GetAllEmployees();
        }
    }
}
