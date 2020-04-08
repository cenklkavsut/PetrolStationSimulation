using System;
using System.Timers;

namespace Assignment_2_PetrolStation
{
    public class Transaction
    {
        public string pet;//check
        private float totalDispensed;//1 Counter no from the app sinopsys
        private float comision;//3 Counter no
        private float litreMoney;//2 //how much money per litres is earned
        private double servisedVehicles;//4 Counter no
        private int vehiclesLeft;//5//if a car leaves add one to it
        private float lpgDispensed;//intermidiate G question
        private float dieselDispensed;//intermidiate G question
        private float petrolDispensed;//6 Counter no
        private double vehicleTypeC;//6 Counter no
        private double pumpNumberC;//6 Counter no
        public string fuelTp;//to choose fuel type for intermidiate last questions.
        public int waitForIt;//it is a timer that wait for the release.

        //tip for later.
        //Vehicle type is related to higest version pump number counter as well
        public float TotalDispensed//1//total fuel dispensed
        {
            get { return totalDispensed; }
            set { totalDispensed = value; }
        }
        public float Comision
        {
            get { return comision; }
            set { comision = value; }
        }
        public float LitreMoney
        {
            get { return litreMoney; }
            set { litreMoney = value; }
        }
        public double ServisedVehicles
        {
            get { return servisedVehicles; }
            set { servisedVehicles = value; }
        }
        public float LpgDispensed
        {
            get { return lpgDispensed; }
            set { lpgDispensed = value; }//intermidiate last question
        }
        public float DieselDispensed
        {
            get { return dieselDispensed; }
            set { dieselDispensed = value; }//intermidiate last question
        }
        public float PetrolDispensed
        {
            get { return petrolDispensed; }
            set { petrolDispensed = value; }
        }
        public double VehicleTypeC
        {
            get { return vehicleTypeC; }
            set { vehicleTypeC = value; }
        }
        public double PumpNumberC
        {
            get { return pumpNumberC; }
            set { pumpNumberC = value; }
        }

        public int VehiclesLeft
        {
            get { return vehiclesLeft; }
            set { vehiclesLeft = value; }
        }

        public void InstanciateResult()
        {
            JustCounters();
            //show all transactions.
            Console.WriteLine("Total vehicles served is {0} \nComision earned for worker is {1} \ndispensed petrol fuel is {2} "
                              +"dispensed LPG is {3} and dispensed Diesel is {4}"
                              , ServisedVehicles, Comision, PetrolDispensed,LpgDispensed,DieselDispensed);
            Console.WriteLine("Amount of times pumps used is {0} and the different types of car servised is {1} "
                              , PumpNumberC, VehicleTypeC);
            //do later a if else to branch it out in fuel type. or a switch with a random
            //if a car leaves add one
        }
        public void JustCounters()
        { //update
            //add to vehicle type
            VehicleTypeC += 1;//change and relate to type of fuel
            //update
            PumpNumberC += 1;//later change it with a if else and connect it with 
            //the program
            //if a vehicle is servised add one
            ServisedVehicles += 1;
            //add the earned litres together if a car is made
            LitreMoney += 2.49f;

            //comision add every time a new car is servised
            Comision += 0.1f;


            PetrolChooser(pet);
            //problem
            if (pet=="Diesel")
            {
                //total diesel dispensed
                DieselDispensed += 1.5f;

            }
            else if (pet == "Petrol")
            {
                //dispensed fuel
                PetrolDispensed += 1.5f;
            }
            else if (pet == "LPG")
            {
                //dispensed LPG counter
                LpgDispensed += 1.5f;
            }
               
            //show result of all dispensed
            TotalDispensed = dieselDispensed + PetrolDispensed + LpgDispensed;
        }
        public void EndResult()
        {
            LeftAdder();//add to the vehicles left//ask
            JustCounters();//increment counter when its called.
            Console.Clear();
            Console.WriteLine("Total vehicles served {0} \nComision earned for worker {1} and total dispensed fuel {2}" +
                              "\nTotal Money Earned £{3}" +
                              "\nToal vehicles that left is {4} "
                              , ServisedVehicles, Comision, TotalDispensed
                              , LitreMoney
                              , VehiclesLeft);
            Console.WriteLine("Thank you for using the application \nHave a good day \n..............Bye");

            //exit application
            Environment.Exit(0);

            Console.ReadLine();
        }

        public string PetrolChooser()
        {
            //Choose type of vehicle
            Random FuelChooser = new Random();
            int myChoice = FuelChooser.Next(1, 4);
            string type="";
            if (myChoice == 1)
            {
                pet = "Diesel";
                type = pet;//type is for fuel make one for the car type too

            }
            else if (myChoice == 2)
            {
                pet = "Petrol";
                type = pet;

            }
            else if (myChoice == 3)
            {
                pet= "LPG";
                type = pet;
            }
            return type;

        }

        /// <summary>
        /// Overload
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int PetrolChooser(string type)
        {
            //Choose type of vehicle
            Random FuelChooser = new Random();
            int myChoice = FuelChooser.Next(1, 4);
            //string type = "";
            if (myChoice == 1)
            {
                pet = "Diesel";
                type = pet;//type is for fuel make one for the car type too

            }
            else if (myChoice == 2)
            {
                pet = "Petrol";
                type = pet;

            }
            else if (myChoice == 3)
            {
                pet = "LPG";
                type = pet;
            }
            return myChoice;

        }
        public string VehicleChooser()
        {

            //Choose the car type
            Random FuelChooser = new Random();
            int  myChoice = FuelChooser.Next(1, 4);

            string type = "";
            if (myChoice == 1)
            {
                pet = "Car";
                type = pet;//type is for fuel make one for the car type too
            }
            else if (myChoice == 2)
            {
                pet = "Van";
                type = pet;
            }
            else if (myChoice == 3)
            {
                pet = "HGV";
                type = pet;
            }
            //return myChoice;
            return type;
            //for higher lever divide  the fueltype and the petrol for car name too choose from and relate it.
            //show type in the car in the thing
        }
        public int ServiceTime(int min, int max)
        {
            Random ranLeave = new Random();
            int betwnVal = ranLeave.Next(min,max);//the number given is the random value number.
            LeftAdder();
            betwnVal -= 1;
            waitForIt = betwnVal;
            return waitForIt;
        }
        public int LeftAdder()
        {
            return vehiclesLeft++;

        }
    }
}