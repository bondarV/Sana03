using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace workWithArray
{
    public class CheckAndTasksArray
    {
        public static int CheckSizeOfArray()
        {
            bool checkN;
            int N;
            Console.WriteLine("Введіть розмір масиву(N):");
            do
            {
                checkN = int.TryParse(Console.ReadLine(), out N);
                if (!checkN || N < 0) Console.WriteLine("Значення N має бути більше нуля та бути числом ");
            } while (!checkN || N < 0);
            Console.WriteLine("Зазначте,що елементи у вказаному вами діапазоні будуть згенеровані у матриці дійсного типу,але округленн(до 2 знаків після коми) дасть змогу отримати ціле число");
            return N;
        }

        public static int CheckArrayFirstLimit()
        {
            bool checkA;
            int a;
            Console.WriteLine("Введіть розмір границі діапазону a - [a;b]");
            do
            {
                checkA = int.TryParse(Console.ReadLine(), out a);
                if (!checkA) Console.WriteLine("Перевірте чи коректно задано значення a [a;b]");
            } while (!checkA);
            return a;
        }
        public static int CheckArraySecondLimit(int a)
        {
            bool checkB;
            int b;
            Console.WriteLine("Введіть розмір границі діапазону b - [a;b]");
            do
            {
                checkB = int.TryParse(Console.ReadLine(), out b);
                if (!checkB || b <= a) Console.WriteLine("Перевірте чи коректно задано значення b [a;b]");
            } while (!checkB || b <= a);
            return b;
        }
        public static double SumNegativeNumbers(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0) sum += array[i];
            return sum;
        }
        public static double MinElementOfArray(double[] array)
        {
            double minElement = array[0];
            for (int i = 0; i < array.Length; i++)
                if (array[i] < minElement) minElement = array[i];
            return minElement;
        }
        public static int MaxElementIndex(double[] array)
        {
            int maxIndexOfElement = 0;
            double maxElement = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    maxIndexOfElement = i;
                }
            }
            return maxIndexOfElement;
        }
        public static double MaxByModuleElement(double[] array)
        {
            double maxByModuleElement = array[0];

            for (int i = 0; i < array.Length; i++)
                if (Math.Abs(array[i]) > Math.Abs(maxByModuleElement)) maxByModuleElement = Math.Abs(array[i]);

            return maxByModuleElement;
        }
        public static int SumIndexPositiveElements(double[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0) sum += i;
            return sum;
        }
        public static int CountIntegerNumbers(double[] array)
        {
            int count = 0;
            int i = 0;
            while (i < array.Length)
            {
                if (array[i] == Math.Round(array[i])) count++;
                i++;
            }
            return count;
        }
    }
}
