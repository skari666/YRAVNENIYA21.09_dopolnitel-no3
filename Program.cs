using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение для альфа:");
        string alphaInput = Console.ReadLine();

        if (!double.TryParse(alphaInput, out double alpha))
        {
            Console.WriteLine("Неправильный формат ввода.");
            return;
        }

        if (alpha == 0)
        {
            Console.WriteLine("Значение альфа не может быть равным нулю.");
            return;
        }

        double result = Math.Cos(alpha) + Math.Sin(alpha) + Math.Pow(Math.Cos(alpha), 2) + Math.Pow(Math.Sin(alpha), 3);

        Console.WriteLine($"Значение Y = {result}");
        Console.ReadKey();
    }
}

