using LW8._1;
using LW8._1.Interfaces;
using System;
using System.Linq;
using System.Text;

namespace LW8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Garage garage = new Garage("LoriBob", new System.Collections.Generic.List<Car>
            {
                new Car("Audi", "R8", "Black", new DieselEngine()),
                new Car("Lamba", "Aventador", "Black", new DieselEngine()),
                new Car("Tesla", "Model S", "White", new ElectronicEngine()),
                new Car("Tesla", "Model 3", "White", new ElectronicEngine()),
                new Car("Tesla", "Model X", "White", new ElectronicEngine())
            });
            var allCars = garage.GetAllCars();
            garage.ShowCars(allCars);
            var car = garage.GetCarsByModel(Console.ReadLine()); //R8
            Console.WriteLine(car.Count); //1
            garage.TakeCarForTravel(allCars.Last().Id);
        }
    }
}
