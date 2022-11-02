namespace EmployeeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // Program p = new Program();
           Robot robot = new Robot("Kalle", 55);
            Console.WriteLine(robot.GetFirstName());
            robot.SetFirstName("Anna");
            Console.WriteLine(robot.GetFirstName());

            robot.Length = 45;
            int length = robot.Length;

           //Robot robot2 = new Robot("Nisse",50);
          // Robot robot3 = new Robot();



           // robot.Name = "Kalle";

           // string name = robot.Name; 
            
           // Robot robot2 = new Robot();
            //robot.Name = "Nisse";

            //string name2 = robot.Name;
        }
    }
}