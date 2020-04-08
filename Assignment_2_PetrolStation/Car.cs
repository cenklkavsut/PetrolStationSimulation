using System;
namespace Assignment_2_PetrolStation
{
    class Car : Vehicle
    {
        public Car(string ftp, double ftm) : base(ftp, ftm)
        {
            FuelType = ftp;
            FuelTime = ftm;
            carID = nextCarID++;
        }

        public void FuelGen()
        {
            /* Transaction trChoice = new Transaction();
            trChoice.fuelTp = FuelType;

            if (fuelType == "Diesel")
            {
                Random fuelChooser = new Random();
                int choice = fuelChooser.Next(0, 3);
                if (choice == 0)
                {
                    FuelType = "Diesel";
                    trChoice.fuelTp = FuelType;
                }
                else if (choice == 1)
                {
                    FuelType = "Petrol";
                    trChoice.fuelTp = FuelType;
                }
                else if (choice == 2)
                {
                    FuelType = "LPG";
                    trChoice.fuelTp = FuelType;
                }

//make a random that genaretes a vehicle type

//for time to  leave 
 /*
  * // evry time a car is created it waits for a certain time and leaves//

             bool start = true;
            if (start != true)
            {
                Transaction transTime = new Transaction();
                transTime.ServiceTime(start);
                vehicles.Remove(v);
            }
            */
        }
    }
}