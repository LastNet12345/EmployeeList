using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    public class Employee
    {
        public string Name { get; set; }
        public uint Salary { get; }
       
        //Konstruktor
        public Employee(string name, uint salary)
        {
            //Validate?
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }

    }
}
