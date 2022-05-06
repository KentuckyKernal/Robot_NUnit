using NUnit.Framework;
using RobotConsole;

namespace TestProject.Tests
{
    public class UnitTest_Password
    {
        [Test]
        public void TestPassword1()
        {
            // can only be tested for true given it is an inifinite loop to the console
            var toTest = new ValidPassword_UnitTestVersion().TestHandler("PLACE");
            Assert.IsTrue(toTest);
        }
    }
}
