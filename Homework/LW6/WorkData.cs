using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LW6
{
    public class WorkData
    {
        public void Reverse(int arr)
        {
            var res = Sort<char>(arr.ToString().ToArray());
            foreach (var val in res)
            {
                Console.Write($"{val}");
            }
            Console.WriteLine();
        }
        public void Reverse(string strings)
        {
            foreach (var item in Sort<string>(strings.ToArray()))
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        public void Reverse(double value)
        {
            Console.WriteLine($"Your value {value}");
            var parts = value.ToString().Split(',');
            foreach (var item in parts)
            {
                var arr = item.ToArray();
                foreach (var otem in Sort<char>(arr))
                {
                    Console.Write($"{otem}");
                }
                Console.Write(".");
            }
        }
        public void Reverse(string[] strings)
        {
            foreach (var item in Sort<string>(strings))
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        public void SortingArray(ref int[] arr, out int[] newArray)
        {
            newArray = Sort<int>(arr);
            arr = newArray;
        }
        public T[] Sort<T>(Array array)
        {
            int index = 0;
            int i = index;
            int j = index + array.Length - 1;
            T[] Array = array as T[];
            if (Array != null)
            {
                while (i < j)
                {
                    T temp = Array[i];
                    Array[i] = Array[j];
                    Array[j] = temp;
                    i++;
                    j--;
                }
            }
            else
            {
                while (i < j)
                {
                    Object temp = Array.GetValue(i);
                    Array.SetValue(Array.GetValue(j), i);
                    Array.SetValue(temp, j);
                    i++;
                    j--;
                }
            }
            return Array;
        }
    }
}