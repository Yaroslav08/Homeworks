using System;
namespace LW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(60, 12, 15);
            Console.WriteLine($"Time to execute task: {calculator.GetHoursOfWalk()} hours");
        }
    }
}