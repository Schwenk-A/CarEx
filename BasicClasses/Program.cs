using System;

namespace BasicClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car newVehicle = new Car();

            newVehicle.Make = "Dodge";
            newVehicle.Model = "Grand Caravan";
            newVehicle.Year = 1996;




            Console.WriteLine($"My new car is a {newVehicle.Year}{newVehicle.Make} {newVehicle.Model} ");
        }
    }
}
