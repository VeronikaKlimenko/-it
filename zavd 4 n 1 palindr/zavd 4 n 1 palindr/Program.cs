using System;

namespace Palindrome

{
    class Program

    {
        static void Main(string[] args)

        {
            Console.WriteLine("Enter a number:");

            int num = int.Parse(Console.ReadLine());

            if (num > 0)

            {

                int original = num;

                int reverse = 0;

                int digit;

                while (num > 0)

                {

                    digit = num % 10;

                    reverse = reverse * 10 + digit;

                    num /= 10;

                }

                digit = 0;

                for (int i = 1; i <= 9; i++)

                {

                    int newNum = original * 10 + i;

                    int newReverse = 0;

                    int temp = newNum;

                    while (temp > 0)

                    {

                        int d = temp % 10;

                        newReverse = newReverse * 10 + d;

                        temp /= 10;

                    }

                    if (newNum == newReverse)

                    {

                        Console.WriteLine("Chislo palindrom s zifroy: " + i);

                        Console.WriteLine(newNum);

                        return;

                    }

                }

                Console.WriteLine("Ne mozlivo zroviti palindrom");

            }
            else Console.WriteLine("Invalid value");

        }

    }

}