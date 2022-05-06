using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotConsole
{
    internal class Command
    {

        public void VisitorCMD(string cmd, Robot rob)
        {
            if( cmd == "REPORT")
            {
                Console.WriteLine(rob.Report());
            }
            else if ( cmd == "PLACE" )
            {
                rob.Placed(rob);
                Console.WriteLine("Robot has been respawned at (" + rob.currentXY[0] + ", " + rob.currentXY[1] + "); facing:" + rob.facing + ";");
            }
            else if (cmd == "LEFT")
            {
                rob.facing = rob.Left(rob.facing);
            }
            else if (cmd == "RIGHT")
            {
                rob.facing = rob.Right(rob.facing);
            }
            else if (cmd == "MOVE")
            {
                rob.currentXY = rob.Moved(rob.facing, rob.currentXY);
            }
            else
            {
                Console.WriteLine(""+cmd+" is not a valid command.");
            }
            
        }
    }
}
