using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        bool checkN, checkA, checkB;
        short N;
        int a, b;
        Random rnd = new Random();

        Console.WriteLine("Введіть розмір масиву(N):");
        do
        {
            checkN = short.TryParse(Console.ReadLine(), out N);
            if (!checkN || N < 0) Console.WriteLine("Значення N має бути більше нуля та бути числом ");
        } while (!checkN || N < 0);

        Console.WriteLine("Введіть розмір границі діапазону a - [a;b]");
        do
        {
            checkA = int.TryParse(Console.ReadLine(), out a);
            if (!checkA || a < 0) Console.WriteLine("Перевірте чи коректно задано значення a [a;b]");
        } while (!checkA || a < 0);

        Console.WriteLine("Введіть розмір границі діапазону b - [a;b]");
        do
        {
            checkB = int.TryParse(Console.ReadLine(), out b);
            if (!checkB || b < 0 || b < a) Console.WriteLine("Перевірте чи коректно задано значення b [a;b]");
        } while (!checkA || b < 0 || b < a);

        int[] array = new int[N];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(a, b + 1);
            Console.WriteLine($"array{i} = {array[i]}");
        }
    }
}
