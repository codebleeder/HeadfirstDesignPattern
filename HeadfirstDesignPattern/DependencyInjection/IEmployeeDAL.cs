using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.DependencyInjection
{
    public interface IEmployeeDAL
    {
        List<Employee> GetAllEmployees();
    }
}
