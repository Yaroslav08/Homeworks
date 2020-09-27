using System;
using System.Collections.Generic;
using System.Text;
namespace LW5
{
    public class Matrix
    {
        public void DisplayMatrix(int [,] arr)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public void ChangeDiagonal(ref int[,] arr)
        {
            for (int i = 0; i < 4; i++)
            {
                arr[i, i] = 0;
            }
        }
        public void ChangeUpperPart(ref int[,] arr)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == 0 && j < 4)
                        arr[i, j] = 0;
                    if (i == 1 && j >= 2 && j <= 3)
                        arr[i, j] = 0;
                    if (i == 2 && j == 3)
                        arr[i, j] = 0;
                }
            }
        }
        public void ChangeLowerPart(ref int[,] arr)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == 0 && i < 4)
                        arr[i, j] = 0;
                    if (j == 1 && i >= 2 && j <= 3)
                        arr[i, j] = 0;
                    if (j == 2 && i == 3)
                        arr[i, j] = 0;
                }
            }
        }
    }
}