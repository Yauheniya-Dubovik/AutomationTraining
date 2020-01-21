using System;
using System.Linq;

namespace Task2ArrayValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {28, 66, 81, 91, 55, 125, 11, 369, 13, 21};
            Array.Sort(arr);
            Console.WriteLine($"Two Min values in array are {arr[0]} ; {arr[1]}");

        }
    }
}