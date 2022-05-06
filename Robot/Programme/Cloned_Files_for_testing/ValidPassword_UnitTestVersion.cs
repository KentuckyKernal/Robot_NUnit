using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotConsole
{
    public class ValidPassword_UnitTestVersion
    {
        public bool TestHandler(string entered)
        {
            bool placeCmd = false;

            Console.WriteLine("type PLACE to Start");
            string toStart = CallStart(entered);

            while (placeCmd == false)
            {
                if (toStart == "PLACE")
                {
                    placeCmd = true;
                }
                else
                {
                    Console.WriteLine("Rob Needs To Be Placed Somewhere.");
                    string pass = CallStart(entered);
                    if (pass == "PLACE")
                    {
                        placeCmd = true;
                    }
                }
            }
            return true;
        }

        public string CallStart(string entered)
        {
            //string entered = Console.ReadLine();
            return entered;
        }
    }
}
