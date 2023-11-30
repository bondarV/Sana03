using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workWithArray
{
    public class Array
    {
        public static double[] RandomGenerationArray(int firstLimit, int secondLimit, int countElements, int digitCount)
        {
            double[] array = new double[countElements]; ;
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(rnd.Next(firstLimit, secondLimit) + rnd.NextDouble(), digitCount);
            }
            return array;
        }

        public static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"arr [{i}] = {array[i]}");
            }
        }
    }
}
