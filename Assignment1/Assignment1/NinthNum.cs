/* Reverse a number*/

using System;

class Program
{
    static void Main()
    {
        int num = 12345;
        Console.WriteLine("Reversed number: " + ReverseNumber(num));
    }

    static int ReverseNumber(int num)
    {
        int reversed = 0;
        while (num > 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }
        return reversed;
    }
}

