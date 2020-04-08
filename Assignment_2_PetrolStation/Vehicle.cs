using System;

namespace Assignment_2_PetrolStation
{
    class Vehicle
    {
        public string fuelType;
        public double fuelTime;

        public string FuelType
        {
            get
            {
                return fuelType;
            }
            set
            {
                fuelType = value;
            }
        }
        public double FuelTime
        {
            get
            {
                return fuelTime;
            }
            set
            {
                fuelTime = value;
            }
        }
        public static int nextCarID = 0;
        public int carID;
        public int CarId
        {
            get
            {
                return carID;
            }
            set
            {
                carID = value;
            }
        }
        public Vehicle(string ftp, double ftm)
        {
          
            FuelType = ftp;
            FuelTime = ftm;
            carID = nextCarID++;

        }
    }
}