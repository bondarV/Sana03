using System;
using System.Collections.Generic;
using System.Linq;
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

        public static int CheckArrayFirstLimit() {
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
    }
}
