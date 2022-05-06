using NUnit.Framework;
using RobotConsole;
using System.Collections.Generic;

namespace TestProject.Tests
{
    internal class UnitTest_PlaceCommand
    {
        [Test]
        public void Test_PLACE_command()
        {
            List<int> list = new List<int>(2) { 0, 0 };

            Robot rob = new Robot();
            rob.facing = rob.Right(rob.facing);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);

            rob.Placed(rob);

            Assert.AreEqual(list, rob.currentXY);
        }

    }
}
