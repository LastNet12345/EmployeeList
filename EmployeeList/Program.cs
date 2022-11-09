using EmployeeList.Helpers;
using EmployeeList.Helpers.MenyHelpers;
using EmployeeList.UI;
//using RobotHelper = EmployeeList.Helpers.Robot;



namespace EmployeeList
{
    internal class Program
    {
        //Programmets startpunkt
        //Får bara finnas EN!
        static void Main(string[] args)
        {
            //object emp = new Employee("Kalle", 23);
            //Console.WriteLine(emp.ToString());
            var r = new EmployeeList.Helpers.Robot();
            var r2 = new RobotHelper();
            var r3 = new Robot("h", 45);
            //Instanseierar en Payroll och ett ConsoleUI
            IPayRoll payRoll = new PayRoll();
            IUI ui = new ConsoleUI();


            Main main = new Main(ui, payRoll);
       //     main.Run();

            try
            {
            Employee emp = new Employee(null, 23);

            }
            catch (ArgumentNullException e)
            {

                
            }
            catch (ArgumentException e)
            {

                
            } 
            catch (Exception e)
            {

                
            }
            finally
            {

            }
        }
    }
}