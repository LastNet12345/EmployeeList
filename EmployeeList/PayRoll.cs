﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    public class PayRoll : IPayRoll
    {
        private List<Employee> payRoll;

        public PayRoll()
        {
            payRoll = new List<Employee>();
            
        }

        public void AddEmployee(string name, uint salary)
        {
            //if (name is null)
            //{
            //    throw new ArgumentNullException(nameof(name));
            //}
            ArgumentNullException.ThrowIfNull(name, $"{nameof(salary)} cannot be null");

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
