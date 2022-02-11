using System;

public class Program
{
    /// <summary>
    /// Модуль числа
    /// </summary>
    /// <param name="x">Число</param>
    /// <returns>Абсолютное значение числа</returns>
    static double Abs(double x)
    {
        return (x < 0) ? -x : x;
    }

    /// <summary>
    /// Знак числа
    /// </summary>
    /// <param name="x">Число</param>
    /// <returns>-1 если число отрицательное, 1 - если положительное</returns>
    static int Sign(double x)
    {
        return (x < 0) ? -1 : 1;
    }

    /// <summary>
    /// Метод бисекции(деления отрезка пополам)
    /// </summary>
    /// <param name="function">Функция</param>
    /// <param name="a">Начало отрезка</param>
    /// <param name="b">Конец отрезка</param>
    /// <param name="precision">Точность вычислений</param>
    /// <returns></returns>
    public static double BisectionMethod(Func<double, double> function, double a, double b, double precision = 1e-10)
    {
        while (true)
        {
            var t = (a + b) / 2;

            if (function(t) == 0.0 || Abs(b - a) < Abs(precision))
            {
                return t;
            }

            if (Sign(function(t)) == Sign(function(a)))
            {
                a = t;
            }
            else
            {
                b = t;
            }
        }
    }

    static void Main(string[] args)
    {
        //локальная функция
        double f(double x) => 3 * Math.Pow(x, 2) - 6 * x + 1;

        Console.WriteLine("Метод бисекции для функции 3x^2 - 6x + 1");
        Console.Write("Введите начало отрезка: ");
        var a = double.Parse(Console.ReadLine());
        Console.Write("Введите конец отрезка: ");
        var b = double.Parse(Console.ReadLine());
        Console.Write("Введите точность вычислений: ");
        var eps = double.Parse(Console.ReadLine());

        var result = BisectionMethod(f, a, b, eps);
        Console.WriteLine("x = {0}\r\nf({0}) = {1}", result, f(result));
        Console.WriteLine("Для выхода нажмите клавишу Enter...");
        Console.ReadKey();
    }
}
