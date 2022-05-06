using NUnit.Framework;
using RobotConsole;
using System.Collections.Generic;

namespace TestProject.Tests
{
    internal class UnitTest_XY
    {
        [Test]
        public void Test_X_1()
        {
            // checking x coordinate only 
            Robot rob = new Robot();
            rob.facing = rob.Right(rob.facing);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            Assert.AreEqual(3, rob.currentXY[0]);
        }

        [Test]
        public void Test_X_2()
        {
            //Testing if robot goes further than the table dimension 5x5 at x coordinate only 

            Robot rob = new Robot();
            rob.facing = rob.Right(rob.facing);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);

            Assert.AreEqual(4, rob.currentXY[0]);
        }

        [Test]
        public void Test_XY_1()
        {
            //Robot should end up at the following coordinates
            List<int> listXY = new List<int>(2) { 2,2 };
            Robot rob = new Robot();

            // North Facing by Default
            // Move Foreward 2 Grid Units
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            // Turn East
            rob.facing = rob.Right(rob.facing);
            // Foreward 2 units
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            rob.currentXY = rob.Moved(rob.facing, rob.currentXY);

            Assert.AreEqual(rob.currentXY, listXY);
        }


    }
}
