using EmployeeList.Helpers;
using EmployeeList.UI;
using Moq;

namespace EmployeeList.XUnitTest
{

    public class UtilTests
    {
        [Fact]
        public void AskForString_ShouldReturnString_WithOurMock()
        {
            const string expected = "NånInput";
            var mockUI = new MockUI();
            mockUI.SetInput = expected;

            var actual = Util.AskForString("", mockUI);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AskForString_ShouldReturnString_WithMoq()
        {
            const string expected = "NånInput";
            var ui = new Mock<IUI>();
            ui.Setup(u => u.GetInput()).Returns(expected);

            var actual = Util.AskForString("", ui.Object);

            Assert.Equal(expected, actual);
        }



    }
}
