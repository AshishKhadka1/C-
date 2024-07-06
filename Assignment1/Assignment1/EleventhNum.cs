/* Factorial of a Number */

using System;

class Program
{
    static void Main()
    {
        int num = 5;
        Console.WriteLine("Factorial of " + num + " is: " + Factorial(num));
    }

    static int Factorial(int num)
    {
        if (num == 0) return 1;
        return num * Factorial(num - 1);
    }
}
