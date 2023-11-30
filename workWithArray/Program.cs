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

        var N = CheckAndTasksArray.CheckSizeOfArray();
        var a = CheckAndTasksArray.CheckArrayFirstLimit();
        var b = CheckAndTasksArray.CheckArraySecondLimit(a);

        var array = workWithArray.Array.RandomGenerationArray(a, b, N, 2);
        workWithArray.Array.PrintArray(array);

        var sumNegativeNumbersOfArray = CheckAndTasksArray.SumNegativeNumbers(array);
        var minElement = CheckAndTasksArray.MinElementOfArray(array);
        var indexOfArrayMaxElement = CheckAndTasksArray.MaxElementIndex(array);
        var maxByModuleElement = CheckAndTasksArray.MaxByModuleElement(array);
        var sumIndexPositiveElements = CheckAndTasksArray.SumIndexPositiveElements(array);
        var countIntegerNumb = CheckAndTasksArray.CountIntegerNumbers(array);

        Console.WriteLine($"Cума від’ємних елементів масиву = {Math.Round(sumNegativeNumbersOfArray, 3)}\nMінімальний елемент масиву = {minElement}\nНомер (індекс) максимального елемента масиву = {indexOfArrayMaxElement}\nMаксимальний за модулем елемент масиву {maxByModuleElement}\nСума індексів додатних елементів {sumIndexPositiveElements}\nКількість цілих чисел у масиві {countIntegerNumb}");
    }
}