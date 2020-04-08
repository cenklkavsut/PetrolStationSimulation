using System;
using System.Collections.Generic;
using System.Timers;

namespace Assignment_2_PetrolStation
{
    class Data
    {
        private static Timer timer;
        public static List<Vehicle> vehicles;
        public static List<Pump> pumps;


        public static void Initialise() {
            InitialisePumps();
            InitialiseVehicles();
        }

        private static void InitialiseVehicles()
        {
            //called the class
            vehicles = new List<Vehicle>();

            timer = new Timer();
            Random ranGen = new Random();
            int ranG = ranGen.Next(1500,2201);

            timer.Interval  = ranG;//the interval is equal to the value 
            timer.AutoReset = true; // keep repeating every 1.5 or 2.2 seconds
            timer.Elapsed += CreateVehicle;
            timer.Enabled = true;
            timer.Start();
        }
        public static void CreateVehicle(object sender, ElapsedEventArgs e)
        {
            //if the car or any type change name to that fuel type and fuel name.
            Transaction transOfFuel = new Transaction();
            // diesel, randomly between 17 and 19 second fuel time
            int fTime;
            Random fTimeGen = new Random();
            fTime= fTimeGen.Next(17,20);

            string choice;
            choice = transOfFuel.pet;//change to the type of fuel used by the vehicles
            transOfFuel.PetrolChooser(choice);

           //when a customer leaves do minus one.//add here the code.
       
            Vehicle v = new Vehicle(choice, fTime * 1000);
                vehicles.Add(v);  

            //ask question error 
            transOfFuel.waitForIt=transOfFuel.ServiceTime(1000, 2001);
            if (transOfFuel.waitForIt == 0)
           {
                transOfFuel.LeftAdder();
               vehicles.Remove(v);
           }
            //ask question error


            // queue limit
            //every time vehicles are created is biger then five it removes one and makes it 5
            if (vehicles.Count >= 6)
                { vehicles.Remove(v);}
        }
        public static void InitialisePumps()
        {//to choose the type of vehicle and petrol
            pumps = new List<Pump>();
            Pump p;
            for (int i = 0; i < 9; i++)
            {
                string choice;
                Transaction trans = new Transaction();
                choice = trans.pet;
                trans.PetrolChooser(choice);
                p = new Pump(choice);//change it to the type of fuel ,the vehicles fuel type.
                pumps.Add(p);
            }
        }
        public static void AssignVehicleToPump()
        {
            Vehicle v;
            Pump p;

            if (vehicles.Count == 0) { return; }

            for (int i = 8; i >= 0; i--)//change back if error accures i=0 <9 i++ evidence of testing
            {
                p = pumps[i];

                // note: needs more logic here, don't just assign to first
                // available pump, but check for the last available pump
                //it assignes for the lat available pump
                    if (p.IsAvailable())
                    {
                        v = vehicles[0]; // get first vehicle

                        vehicles.RemoveAt(0); // remove vehicles from queue

                        p.AssignVehicle(v); // assign it to the pump
                    }

                if (vehicles.Count == 0) { break; }
            }
        }
    }
}