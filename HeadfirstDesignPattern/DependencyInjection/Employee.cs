using System;
using System.Collections.Generic;
using System.Text;

namespace HeadfirstDesignPattern.DependencyInjection
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public Employee(int id, string name, string department)
        {
            Id = id;
            Name = name;
            Department = department;
        }
        public override string ToString()
        {
            return $"{Id} {Name} from {Department} department";
        }
    }
}
