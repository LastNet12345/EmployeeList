namespace EmployeeList.MSTest
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void SalaryLevel_Get_ShouldReturn_SalaryLevelJunior()
        {
            // Arrange
            const int juniorSalary = 10000;
            const string name = "Kalle";
            var emp = new Employee(name, juniorSalary);
            var expected = SalaryLevel.Junior;

            // Act
            var actual = emp.SalaryLevel;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        //[DataTestMethod]
        //[DataRow(2)]
        //[DataRow(20)]
        //[DataRow(200)]
        //[DataRow(24999)]
        //public void SalaryLevel_Get_ShouldReturn_SalaryLevelJunior2(uint salary)
        //{
        //    // Arrange
        //    const string name = "Kalle";
        //    var emp = new Employee(name, salary);
        //    var expected = SalaryLevel.Junior;

        //    // Act
        //    var actual = emp.SalaryLevel;

        //    // Assert
        //    Assert.AreEqual(expected, actual);
        //}


    }
}