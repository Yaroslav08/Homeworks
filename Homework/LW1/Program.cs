using System;
using System.Text;

namespace LW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Лабораторна робота №1, Варіант 14");
            Calculator calculator = new Calculator(60, 12, 15);
            Console.WriteLine($"Час через який вони зустрінуться: {calculator.GetHoursOfWalk()} годин");
        }
    }
}