using EmployeeList.Helpers;
using EmployeeList.Helpers.MenyHelpers;

namespace EmployeeList
{
    internal class Program
    {

        static PayRoll payRoll = new PayRoll();
        static void Main(string[] args)
        {

            SeedData();

            do
            {
                ShowMainMeny();
                string input = Console.ReadLine()!;

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

        private static void AddEmployee()
        {
            string name = Util.AskForString("Name");
            uint salary = Util.AskForUInt("Salary");

            payRoll.AddEmployee(name, salary);
        }

        private static void PrintEmployees()
        {
            List<Employee> employees = payRoll.GetEmplyees();

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }

        private static void ShowMainMeny()
        {
            Console.WriteLine($"{MenyHelpers.Add}. add employee");
            Console.WriteLine($"{MenyHelpers.Print}. print employee");
            Console.WriteLine($"{MenyHelpers.Quit}. quit");
        }

        private static void SeedData()
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