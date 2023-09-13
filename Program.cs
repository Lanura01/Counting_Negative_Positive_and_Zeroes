using System;
class Program
{
    private static void Main(string[] args)
    {
        int num1, num2, num3, num4, num5;
        Console.WriteLine("Please Enter Five numbers below!");

        Console.WriteLine("Enter number 1: ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number 2: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number 3: ");
        num3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number 4: ");
        num4 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number 5: ");
        num5 = int.Parse(Console.ReadLine());

        if (num1 == 0)
        {
            Console.WriteLine(num1 + " is Zero");
        }

        if (num1 > 0)
        {
            Console.WriteLine(num1 + " is Positive");
        }

        if (num1 < 0)
        {
            Console.WriteLine(num1 + " is Negative");
        }


        if (num2 == 0)
        {
            Console.WriteLine(num2 + "is Zero");
        }

        if (num2 > 0)
        {
            Console.WriteLine(num2 + "is Positive");
        }

        if (num2 < 0)
        {
            Console.WriteLine(num2 + " is Negative");
        }


        if (num3 == 0)
        {
            Console.WriteLine(num3 + " is Zero");
        }

        if (num3 > 0)
        {
            Console.WriteLine(num3 + " is Positive");
        }

        if (num3 < 0)
        {
            Console.WriteLine(num3 + " is Negative");
        }


        if (num4 == 0)
        {
            Console.WriteLine(num4 + " is Zero");
        }

        if (num4 > 0)
        {
            Console.WriteLine(num4 + " is Positive");
        }

        if (num4 < 0)
        {
            Console.WriteLine(num4 + " is Negative");
        }


        if (num5 == 0)
        {
            Console.WriteLine(num5 + " is Zero");
        }

        if (num5 > 0)
        {
            Console.WriteLine(num5 + " is Positive");
        }

        if (num5 < 0)
        {
            Console.WriteLine(num5 + " is Negative");
        }
    }
}