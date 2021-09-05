using System;
using static System.Console;

delegate double Calculate(int n);

class Program
{
    public static void Main(string[] args)
    {
        int x = int.Parse(ReadLine());

        Calculate calculate = x =>
        {
            double a = 0;
            double b = 0;
            for (double i = 1.0; i <= 5.0; i++)
            {
                b = 1;
                for (double j = 1.0; j <= 5.0; j++)
                {
                    b *= ((i + 42) * x) / (j * j);
                }
                a += b;
            }
            return Math.Round(a, 3);
        };

        Write(calculate(x));
    }
}
