using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    public class PayRoll
    {
        private List<Employee> payRoll;

        public PayRoll()
        {
            payRoll = new List<Employee>();
        }

        public void AddEmployee(string name, uint salary)
        {
            Employee employee = new Employee(name, salary);
            payRoll.Add(employee);
        }
        public void AddEmployee(Employee employee)
        {
            payRoll.Add(employee);
        } 

        public List<Employee> GetEmplyees()
        {
            return payRoll.ToList();
        }

    }
}
