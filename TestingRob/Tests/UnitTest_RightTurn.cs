using NUnit.Framework;
using RobotConsole;

namespace TestProject.Tests
{
	public class UnitTest_RightTurn
	{
		[Test]
		public void TestRightTurn1()
        {
			Robot rob = new Robot();
			rob.facing = rob.Right(rob.facing);

			Assert.AreEqual('E', rob.facing);
        }

		[Test]
		public void TestRightTurn2()
		{
			Robot rob = new Robot();
			rob.facing = rob.Right(rob.facing);
			rob.facing = rob.Right(rob.facing);

			Assert.AreEqual('S', rob.facing);
		}
		[Test]
		public void TestRightTurn3()
		{
			Robot rob = new Robot();
			rob.facing = rob.Right(rob.facing);
			rob.facing = rob.Right(rob.facing);
			rob.facing = rob.Right(rob.facing);

			Assert.AreEqual('W', rob.facing);
		}
		[Test]
		public void TestRightTurn4()
		{
			Robot rob = new Robot();
			rob.facing = rob.Right(rob.facing);
			rob.facing = rob.Right(rob.facing);
			rob.facing = rob.Right(rob.facing);
			rob.facing = rob.Right(rob.facing);

			Assert.AreEqual('N', rob.facing);
		}
	}
}