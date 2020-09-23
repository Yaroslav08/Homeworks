using System;
using System.Linq;

namespace LW4
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 4, 8, 16, 32, 64, 128 };
            Console.WriteLine(GetCount(arr));
        }

        static int GetCount(params int[] arr)
        {
            int count = 0;
            int currentElement = 0;
            int? nextElement = 0;
            int currentIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                currentIndex = i;
                if (currentIndex + 1 == arr.Length)
                    break;
                currentElement = arr[currentIndex];
                nextElement = arr[++currentIndex];
                if (currentElement * 2 == nextElement)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
