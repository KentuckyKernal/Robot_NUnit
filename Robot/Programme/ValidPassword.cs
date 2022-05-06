using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotConsole
{
    internal class ValidPassword
    {
        public bool Handler()
        {
            bool placeCmd = false;

            Console.WriteLine("type PLACE to Start");
            string toStart = CallStart();

            while (placeCmd == false)
            {
                if (toStart == "PLACE")
                {
                    placeCmd = true;
                }
                else
                {
                    Console.WriteLine("Rob Needs To Be Placed Somewhere.");
                    string pass = CallStart();
                    if (pass == "PLACE")
                    {
                        placeCmd = true;
                    }
                }
            }
            return true;
        }

        public string CallStart()
        {
            string entered = Console.ReadLine();
            return entered;
        }

    }
}
