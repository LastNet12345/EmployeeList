using EmployeeList.Helpers;
using EmployeeList.Helpers.MenyHelpers;
using EmployeeList.UI;

namespace EmployeeList
{
    internal class Program
    {
        //Programmets startpunkt
        //Får bara finnas EN!
        static void Main(string[] args)
        {
            //Instanseierar en Payroll och ett ConsoleUI
            IPayRoll payRoll = new PayRoll();
            IUI ui = new ConsoleUI();

            Main main = new Main(ui, payRoll);
            main.Run();
        }
    }
}