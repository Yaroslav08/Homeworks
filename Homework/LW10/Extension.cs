using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LW10
{
    public static class Extension
    {
        public static double GetSumAvarage(this int[] array) => array.Average();
        public static double GetMultiAvarage(this int[] array)
        {
            double result = 1;
            foreach (var item in array)
            {
                result *= item;
            }
            return result / array.Length;
        }
    }
}