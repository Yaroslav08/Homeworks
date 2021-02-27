using LW8._1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
namespace LW8._1
{
    public class Car
    {
        private string id = Guid.NewGuid().ToString();
        private string brand;
        private string model;
        private string color;
        private IEngine engine;

        public string Id => id;
        public string Brand => brand;
        public string Model => model;
        public string Color => color;
        public IEngine Engine => engine;
        public Car(string brand, string model, string color, IEngine engine)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.engine = engine;
        }


        public override string ToString()
        {
            return $"Brand: {brand}, Model: {model}, Color: {color}";
        }
    }
}