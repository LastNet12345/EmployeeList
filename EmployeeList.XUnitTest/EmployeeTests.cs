namespace EmployeeList.XUnitTest
{
    public class EmployeeTests
    {

        const int juniorSalary = 10000;
        const string name = "Kalle";

        [Fact]
        public void SalaryLevel_Get_ShouldReturn_SalaryLevelJunior()
        {
            // Arrange
            var emp = new Employee(name, juniorSalary);
            var expected = SalaryLevel.Junior;

            // Act
            var actual = emp.SalaryLevel;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SalaryLevel_Get_ShouldReturn_SalaryLevelSenior()
        {
            // Arrange
            var emp = new Employee(name, 30000);
            var expected = SalaryLevel.Senior;

            // Act
            var actual = emp.SalaryLevel;

            // Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        //[InlineData("h", 24999)]
        //[InlineData(true, 1000)]
        [InlineData(9)]
        [InlineData(999)]
        [InlineData(2)]
        [InlineData(1314)]
        public void SalaryLevel_Get_ShouldReturn_SalaryLevelJunior2(/*string name2, */uint salary)
        {
            // Arrange
            var emp = new Employee(name, salary);
            var expected = SalaryLevel.Junior;

            // Act
            var actual = emp.SalaryLevel;

            // Assert
            Assert.Equal(expected, actual);
        }


    }
}