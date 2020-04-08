using System;
namespace Assignment_2_PetrolStation
{
   class Van:Vehicle
    {
        public Van(string ftp, double ftm) : base(ftp, ftm)
        {
            FuelType = ftp;
            FuelTime = ftm;
            carID = nextCarID++;
        }

        public void FuelGen()
        {
            /*
            if (FuelType == "Van")
            {
                Transaction trChoice = new Transaction();

                Random fuelChooser = new Random();
                int choice = fuelChooser.Next(0, 2);
                if (choice == 0)
                {
                    FuelType = "Diesel";
                    trChoice.fuelTp = FuelType;
                }

                else if (choice == 1)
                {
                    FuelType = "LPG";

                    trChoice.fuelTp = FuelType;
                }
            }*/
        }

    }
}
