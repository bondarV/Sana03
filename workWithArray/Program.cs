using System.ComponentModel.Design;
using System.Text;
internal class Program
{

    private static void randomGenerationArray(double[] array, int firstLimit, int secondLimit)
    {
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round(rnd.Next(firstLimit, secondLimit) + rnd.NextDouble(), 2);
            Console.WriteLine($"array [{i}] = {array[i]}");
        }
    }
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        bool checkN, checkA, checkB;
        short N;
        int a, b;

        Console.WriteLine("Введіть розмір масиву(N):");
        do
        {
            checkN = short.TryParse(Console.ReadLine(), out N);
            if (!checkN || N < 0) Console.WriteLine("Значення N має бути більше нуля та бути числом ");
        } while (!checkN || N < 0);
        Console.WriteLine("Зазначте,що елементи у вказаному вами діапазоні будуть згенеровані у матриці дійсного типу,але округленн(до 2 знаків після коми) дасть змогу отримати ціле число");
        Console.WriteLine("Введіть розмір границі діапазону a - [a;b]");
        do
        {
            checkA = int.TryParse(Console.ReadLine(), out a);
            if (!checkA) Console.WriteLine("Перевірте чи коректно задано значення a [a;b]");
        } while (!checkA);

        Console.WriteLine("Введіть розмір границі діапазону b - [a;b]");
        do
        {
            checkB = int.TryParse(Console.ReadLine(), out b);
            if (!checkB || b <= a) Console.WriteLine("Перевірте чи коректно задано значення b [a;b]");
        } while (!checkA || b <= a);

        double[] array = new double[N];
        randomGenerationArray(array, a, b);

        double minElement = array[0];
        double maxElement = array[0];
        int indexMax = 0;
        double maxByModulElement = Math.Abs(array[0]);
        int sumIndexDotElement = 0;
        double sumNegativeNumbers = 0;
        int countIntegerNumb = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - 1)
            {
                if (array[i + 1] < minElement)
                {
                    minElement = array[i + 1];
                }
            }
            if (array[i] < 0) sumNegativeNumbers += array[i];
            if (array[i] > 0) sumIndexDotElement += i;
            if (array[i] == Math.Round(array[i])) countIntegerNumb++;
            if (Math.Abs(array[i]) > maxByModulElement) maxByModulElement = Math.Abs(array[i]);
            if (array[i] > maxElement)
            {
                maxElement = array[i];
                indexMax = i;

            }
        }
        Console.WriteLine($"Cума від’ємних елементів масиву = {Math.Round(sumNegativeNumbers, 3)}\nMінімальний елемент масиву = {minElement}\nНомер (індекс) максимального елемента масиву = {indexMax}\nMаксимальний за модулем елемент масиву {maxByModulElement}\nСума індексів додатних елементів {sumIndexDotElement}\nКількість цілих чисел у масиві {countIntegerNumb}");
    }
}