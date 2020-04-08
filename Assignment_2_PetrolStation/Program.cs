using System;
using System.Timers;

namespace Assignment_2_PetrolStation
{
    class Program
    {
        //you just call the results of the transaction in the end to see results
        static  Transaction justCallIt = new Transaction();
        static void Main(string[] args)
        {
            Data.Initialise();

            Timer timer = new Timer();
            timer.Interval = 2050;
            timer.AutoReset = true; // repeat every 2 seconds
            timer.Elapsed += RunProgramLoop;
            timer.Enabled = true;
            timer.Start();

            Console.ReadLine();
            justCallIt.EndResult();
            //pause and end
            Console.ReadLine();
        }
        static void RunProgramLoop(object sender, ElapsedEventArgs e)
        {
            Console.Clear();
            Display.DrawVehicles();
            Console.WriteLine();
            Console.WriteLine();
            justCallIt.InstanciateResult();
            Console.WriteLine();
            Display.DrawPumps();
            Data.AssignVehicleToPump();
        }
    }
}