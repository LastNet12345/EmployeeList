namespace EmployeeList
{
    public interface IPayRoll
    {
        void AddEmployee(Employee employee);
        void AddEmployee(string name, uint salary);
        List<Employee> GetEmplyees();
    }
}