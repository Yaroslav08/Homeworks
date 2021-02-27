using System;
using System.Text;
namespace LW10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var array = new int[] { 1, 2, 34, 67, 9879 };
            Console.WriteLine($"Середне арифметичне значення - {array.GetSumAvarage()}");
            Console.WriteLine($"Середне геометричне значення - {array.GetMultiAvarage()}");
        }
    }
}