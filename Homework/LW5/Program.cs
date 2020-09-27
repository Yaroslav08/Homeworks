using System;

namespace LW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = Matrix.GetInstance();
            var arr = new int[,] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 }, { 12, 13, 14, 15 } };
            matrix.DisplayMatrix(arr);
            matrix.ChangeUpperPart(ref arr);
            matrix.DisplayMatrix(arr);
            matrix.ChangeDiagonal(ref arr);
            matrix.DisplayMatrix(arr);
            matrix.ChangeLowerPart(ref arr);
            matrix.DisplayMatrix(arr);
        }
        
    }
}
