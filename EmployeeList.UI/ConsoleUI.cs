namespace EmployeeList.UI
{
    public class ConsoleUI : IUI
    {
        public string GetInput()
        {
            return Console.ReadLine()!;
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
    
    public class MockUI : IUI
    {
        public string SetInput { private get; set; } = "Default";
        public string GetInput()
        {
            return SetInput;
        }

        public void Print(string message)
        {
        }
    }
}