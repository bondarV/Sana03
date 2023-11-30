using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Text;
using workWithArray;
internal class Program
{

    private static void Main(string[] args)
    {

        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        var N = workWithArray.CheckAndTasksArray.CheckSizeOfArray();
        var a = workWithArray.CheckAndTasksArray.CheckArrayFirstLimit();
        var b = workWithArray.CheckAndTasksArray.CheckArraySecondLimit(a);

        var array = workWithArray.Array.RandomGenerationArray(a, b, N, 2);
        workWithArray.Array.PrintArray(array);

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