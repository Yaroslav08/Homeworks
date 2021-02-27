using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LW8._1.Interfaces
{
    public class DieselEngine : IEngine
    {
        public int GetPower()
        {
            return new Random().Next(90, 1800);
        }

        public void StartEngine()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("вжух\t");
                Thread.Sleep(100);
            }
            Console.WriteLine();
            Console.WriteLine("Diesel engine started, let`s go!");
        }
    }
}