/*Generate nth Term of Fibonacci Series Using Iterative Approach
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
		int a = 0, b = 1, c = 0;
		if (n == 0) return a;
		for (int i = 2; i <= n; i++)
		{
			c = a + b;
			a = b;
			b = c;
		}
		return b;
	}
}
=