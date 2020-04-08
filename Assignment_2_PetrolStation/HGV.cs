using System;
namespace Assignment_2_PetrolStation
{
    class HGV:Vehicle
    {
        public HGV(string ftp, double ftm) : base(ftp, ftm)
        {
            FuelType = ftp;

            FuelTime = ftm;
            carID = nextCarID++;
        }

        /*public void FuelGen()
        {
            if (FuelType=="HGV")
            {
                fuelType = "Diesel";
            
                Transaction trChoice = new Transaction();
                trChoice.fuelTp = FuelType;
            }
               
        }*/
    }
}