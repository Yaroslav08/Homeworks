using System;
using System.Linq;

namespace LW4
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[,] { { 1, 2 }, { 4, 56 }, { 45, 46 }, { 13, 12 }, { 67, 5 } };
            Console.WriteLine($"Common count - {GetCount(arr)}"); //3
        }

        static int GetCount(int[,] arr)
        {
            int count = 0;
            int currentIndexI = 0, currentIndexJ = 0, currentElement = 0, nextElement = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    currentIndexI = i;
                    currentIndexJ = j;
                    currentElement = arr[i, j];
                    if (j == 1)
                    {
                        if (i == 4)
                            break;
                        nextElement = arr[(i) + 1, j];
                    }
                    else
                    {
                        nextElement = arr[i, (j) + 1];
                    }
                    if (currentElement + 1 == nextElement || currentElement - 1 == nextElement)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
