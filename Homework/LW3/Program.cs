using System;

namespace LW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            string num = Console.ReadLine();
            if (num.Length == 3)
            {
                double n1 = Convert.ToDouble(num[0].ToString());
                double n2 = Convert.ToDouble(num[1].ToString());
                double n3 = Convert.ToDouble(num[2].ToString());
                Console.WriteLine(n2 / n1 == n3 / n2);
            }
        }
    }
}
