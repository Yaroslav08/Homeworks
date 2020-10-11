using System;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;

namespace LW7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var lists = new List<int>
                {
                    4,
                    34,
                    765,
                    325,
                    234,
                    8796546,
                    20,
                    18,
                    19
                };
                IWorker<int> worker = new WorkerInt(lists);
                WriteLine("Please enter new value for add to list");
                worker.AddValueToList(ToInt32(ReadLine()));
                WriteLine("Enter number for get index of this value");
                int value = ToInt32(ReadLine());
                WriteLine($"Index of {value} is {worker.GetIndexByValue(value)}");
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
