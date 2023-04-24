using System;

internal class Program
{

    private static void Main(string[] args)
    {

        Console.Write("Vvedid x: ");

        Double x = Convert.ToDouble(Console.ReadLine());

        Double y = 0;

        if (x <= 4)
        {

            y = (x * x + 5 * x + 1) / 2;

        }

        else if (x >= 16)
        {

            for (Double i = 16; i <= x; i++)
            {

                y = y + Math.Pow(((2 + i) / 4), 2);

            }

        }

        else
        {

            y = 1;

            for (Double i = 5; i <= x; i++)
            {

                y = y * Math.Pow(1 + Math.Pow(i, 3), 2);

            }

        }

        Console.Write($"Y: {y} ");

    }

}
