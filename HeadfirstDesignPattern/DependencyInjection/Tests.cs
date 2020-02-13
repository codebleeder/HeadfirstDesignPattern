using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.DependencyInjection
{
    public static class Tests
    {
        public static void Test1()
        {
            // without DI
            Console.WriteLine("without dependency injection: ");
            var employeeBLL1 = new EmployeeBLL();
            employeeBLL1.GetAllEmployees().ForEach(e => Console.WriteLine(e.ToString()));

            // with DI
            Console.WriteLine("\ndependency injection using constructor injection: ");
            var employeeBLL = new EmployeeBLL_ConstructorInjection(new EmployeeDAL2());
            employeeBLL.GetAllEmployees().ForEach(e => Console.WriteLine(e.ToString()));

            Console.WriteLine("\ndependency injection using property injection: ");
            var employeeBLL_PropertyInjection = new EmployeeBLL_PropertyInjection();
            employeeBLL_PropertyInjection.EmployeeDALObj = new EmployeeDAL2();
            employeeBLL_PropertyInjection.GetAllEmployees().ForEach(e => Console.WriteLine(e.ToString()));

            Console.WriteLine("\ndependency injection using method injection: ");
            var employeeBLL_MethodInjection = new EmployeeBLL_MethodInjection();
            employeeBLL_MethodInjection.GetAllEmployees(new EmployeeDAL2()).ForEach(e => Console.WriteLine(e.ToString()));
        }
    }
}
