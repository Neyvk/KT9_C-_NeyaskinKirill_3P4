using System;

class Calculator<T> where T : new()
{
    public static T Zero()
    {
        return new T();
    }

    public static T Add(T x, T y)
    {
        dynamic dx = x;
        dynamic dy = y;

        return dx + dy;
    }
}
class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        int sum = Calculator<int>.Add(a, b);
        int zeroInt = Calculator<int>.Zero();

        Console.WriteLine($"Сумма int: {sum}");
        Console.WriteLine($"Нулевое значение int: {zeroInt}");

        double x = 2.5;
        double y = 3.7;

        double sumDouble = Calculator<double>.Add(x, y);
        double zeroDouble = Calculator<double>.Zero();

        Console.WriteLine($"Сумма double: {sumDouble}");
        Console.WriteLine($"Нулевое double: {zeroDouble}");

        Console.ReadLine();
    }
}
