/*Generate nth Term of Fibonacci Series Using Recursive Approach
*/
using System;

class Program
{
    static void Main()
    {
        int n = 10;
        Console.WriteLine("The " + n + "th term of the Fibonacci series is: " + Fibonacci(n));
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
