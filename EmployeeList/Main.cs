using EmployeeList.Helpers;
using EmployeeList.Helpers.MenyHelpers;
using EmployeeList.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    public class Main
    {
        private readonly IUI ui;
        private readonly IPayRoll payRoll;

        public Main(IUI ui, IPayRoll payRoll)
        {
            this.ui = ui;
            this.payRoll = payRoll;
        }
        public void Run()
        {
            SeedData();

            do
            {
                ShowMainMeny();
                string input = ui.GetInput()!;

                switch (input)
                {
                    case MenyHelpers.Add:
                        AddEmployee();
                        break;
                    case MenyHelpers.Print:
                        PrintEmployees();
                        break;
                    case MenyHelpers.Quit:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }



            } while (true);
        }

        private void AddEmployee()
        {
            string name = Util.AskForString("Name", ui);
            uint salary = Util.AskForUInt("Salary", ui);

            payRoll.AddEmployee(name, salary);
        }

        private void PrintEmployees()
        {
            List<Employee> employees = payRoll.GetEmplyees();

            foreach (Employee employee in employees)
            {
                ui.Print(employee.ToString());
            }
        }

        private void ShowMainMeny()
        {
            ui.Print($"{MenyHelpers.Add}. add employee");
            ui.Print($"{MenyHelpers.Print}. print employee");
            ui.Print($"{MenyHelpers.Quit}. quit");
        }

        private void SeedData()
        {
            payRoll.AddEmployee("Anna", 36000);
            payRoll.AddEmployee("Bengt", 30000);
            payRoll.AddEmployee("Pelle", 4000);
            payRoll.AddEmployee("Lars", 60000);
            payRoll.AddEmployee("Anna", 35000);
            payRoll.AddEmployee("Anna", 5000);
        }
    }
}
