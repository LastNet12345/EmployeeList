using EmployeeList.Helpers;
using EmployeeList.Helpers.MenyHelpers;
using EmployeeList.UI;

namespace EmployeeList
{
    internal class Program
    {

        static void Main(string[] args)
        {

            IPayRoll payRoll = new PayRoll();
            IUI ui = new ConsoleUI();

            Main main = new Main(ui, payRoll);
            main.Run();
        }
    }
}