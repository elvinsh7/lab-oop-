using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using icherishahar;

namespace icherishahar
{
    class Car : Vehicle
    {
        public Car(string brand, string model, double fuelCapacity, double fuelFor1km, double currentFuel, string color, int year)
            : base(color, year)
        {
            Brand = brand;
            Model = model;
            FuelCapacity = fuelCapacity;
            FuelFor1km = fuelFor1km;
            CurrentFuel = currentFuel;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public double FuelCapacity { get; set; }
        public double FuelFor1km { get; set; }
        public double CurrentFuel { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Cars brand is {Brand}, model is {Model} with {color} color");
        }
        public void Drive(int km)
        {
            double necessaryFuel = km * FuelFor1km;
            if (CurrentFuel > necessaryFuel)
            {
                Console.WriteLine($"{CurrentFuel - necessaryFuel}L benzin qalacaq!");
            }
            else if (CurrentFuel < necessaryFuel)
            {
                Console.WriteLine($"Sizin benzininiz bittikden sonra {necessaryFuel - CurrentFuel}L benzine ehtiyaciniz olacaq! Umumi ehtiyac {necessaryFuel}");
            }
            else
            {
                Console.WriteLine("Yolu tamamladiqdan sonra benzin qalmayacaq!");
            }
        }
    }
}
