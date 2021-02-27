using LW8._1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LW8._1
{
    public class Garage
    {
        private string sheikhsName;
        private List<Car> cars;

        public string NameOfSheikhs => sheikhsName;

        public List<Car> GetAllCars() => cars;
        public List<Car> GetCarsByBrand(string brand) => cars.Where(d => d.Brand == brand).ToList();
        public List<Car> GetCarsByModel(string model) => cars.Where(d => d.Model == model).ToList();
        public List<Car> GetCarsByColor(string color) => cars.Where(d => d.Color == color).ToList();
        public void AddCar(Car car) => cars.Add(car);
        public void TakeCarForTravel(string id)
        {
            var car = cars.FirstOrDefault(d => d.Id == id);
            car.Engine.StartEngine();
        }
        public void RevokeCar(string id) => cars.Remove(cars.SingleOrDefault(d => d.Id == id));
        public void ShowCars(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        public Garage(string Name, List<Car> cars)
        {
            sheikhsName = Name;
            this.cars = cars;
        }
    }
}