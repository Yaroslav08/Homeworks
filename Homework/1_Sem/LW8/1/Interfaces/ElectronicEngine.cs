using System;
using System.Collections.Generic;
using System.Text;
namespace LW8._1.Interfaces
{
    public class ElectronicEngine : IEngine
    {
        public int GetPower()
        {
            return new Random().Next(70, 600);
        }

        public void StartEngine()
        {
            Console.WriteLine("Вжух");
            Console.WriteLine("Electronic engine started, let`s go!");
        }
    }
}