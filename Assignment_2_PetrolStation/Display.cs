using System;
namespace Assignment_2_PetrolStation
{
    public class Display
    {
		public static void DrawVehicles()
		{
            //you can put here HGV Van and car the names add something to the display.
			Vehicle v;
            //queue related
			Console.WriteLine("Vehicles Queue:");
            for (int i = 0; i < Data.vehicles.Count; i++)
            {
                v = Data.vehicles[i];
                string myVehicle="";
               
                Transaction chooseToDisplay = new Transaction();//
              v.FuelType=  chooseToDisplay.PetrolChooser();//take it out if its wrong.//add this later ask question about it
                //and Vehicle Type is {2}
               myVehicle= chooseToDisplay.VehicleChooser();
                //here add for type and name somthing for the vehicle
                Console.Write("#{0} Fuel Type: {1} and Vehicle Type is {2} | ", v.CarId,v.FuelType,myVehicle);
                //for extra later make carid 0 if it reaches a certain count.
			}
		}
		public static void DrawPumps()
		{
			Pump p;

			Console.WriteLine("Pumps Status:");

			for (int i = 0; i < 9; i++)
			{
				p = Data.pumps[i];

				Console.Write("#{0} ", i + 1);
				if (p.IsAvailable()) { Console.Write("FREE"); }
				else { Console.Write("BUSY"); }
				Console.Write(" | ");

                // modulus -> remainder of a division operation
                // 0 % 3 => 0 (0 / 3 = 0 R=0)
                // 1 % 3 => 1 (1 / 3 = 0 R=1)
                // 2 % 3 => 2 (2 / 3 = 0 R=2)
                // 3 % 3 => 0 (3 / 3 = 1 R=0)
                // 4 % 3 => 1 (4 / 3 = 1 R=1)
                // 5 % 3 => 2 (5 / 3 = 1 R=2)
                // 6 % 3 => 0 (6 / 3 = 2 R=0)
                // ...
				if (i % 3 == 2) { Console.WriteLine(); }
			}
		}
    }
}