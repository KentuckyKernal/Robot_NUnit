using System;


namespace RobotConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool valid = false;
            //initialise robot object
            Robot rob = new Robot();

            valid  = new ValidPassword().Handler();
            
            Console.WriteLine("\n Excellent. Robs happy and sitting at (" + rob.currentXY[0] + "," + rob.currentXY[1] + ") \n");

            while (valid)
            {
                Console.Write(">>>");
                string currentEntry = Console.ReadLine();
                new Command().VisitorCMD(currentEntry, rob);
            }
        }
    }
}