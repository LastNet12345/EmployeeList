namespace EmployeeList
{
    internal class Program
    {

        static PayRoll payRoll = new PayRoll();
        static void Main(string[] args)
        {

            Employee kalle = new Employee("Kalle", 35000);
            payRoll.AddEmployee(kalle);

            List<Employee> employees = payRoll.GetEmplyees();
            
            Console.WriteLine(employees[0]);

            // employees[0] = new Employee("Anna", 35);
            employees[0].Name = "Anna";

            Console.WriteLine(employees[0]);

            List<Employee> afterReplace = payRoll.GetEmplyees();

            Console.WriteLine(afterReplace[0]);

            



            SeedData();

            do
            {
                ShowMainMeny();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":

                        break;
                    case "2":
                        PrintEmployees();
                        break;
                    case "Q":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }



            } while (true);

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
            Console.WriteLine("1. add employee");
            Console.WriteLine("2. print employee");
            Console.WriteLine("Q. quit");
        }

        private static void SeedData()
        {
            payRoll.AddEmployee("Anna", 36000);
            payRoll.AddEmployee("Bengt", 30000);
            payRoll.AddEmployee("Pelle", 45000);
            payRoll.AddEmployee("Lars", 60000);
            payRoll.AddEmployee("Anna", 35000);
            payRoll.AddEmployee("Anna", 35000);
        }
    }
}