using NUnit.Framework;
using RobotConsole;

namespace TestProject.Tests
{
    public class UnitTest_LeftTurn
    {

        [Test]
        public void TestFaceStart()
        {
           Robot rob = new Robot();

           Assert.AreEqual('N', rob.facing);
        }
        [Test]
        public void TestLeft1()
        {
            Robot rob = new Robot();
            rob.facing = rob.Left(rob.facing);

            Assert.AreEqual('W', rob.facing);
        }
        [Test]
        public void TestLeft2()
        {
            Robot rob = new Robot();
            rob.facing = rob.Left(rob.facing);
            rob.facing = rob.Left(rob.facing);
            Assert.AreEqual('S', rob.facing);
        }
        [Test]
        public void TestLeft3()
        {
            Robot rob = new Robot();
            rob.facing = rob.Left(rob.facing);
            rob.facing = rob.Left(rob.facing);
            rob.facing = rob.Left(rob.facing);
            Assert.AreEqual('E', rob.facing);
        }
        public void TestLeft4()
        {
            Robot rob = new Robot();
            rob.facing = rob.Left(rob.facing);
            rob.facing = rob.Left(rob.facing);
            rob.facing = rob.Left(rob.facing);
            rob.facing = rob.Left(rob.facing);
            Assert.AreEqual('N', rob.facing);
        }



    }
}