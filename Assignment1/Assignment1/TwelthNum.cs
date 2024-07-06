/* Sum of digits of a number */


using System;

class Program
{
	static void Main()
	{
		int num = 12345;
		Console.WriteLine("Sum of digits: " + SumOfDigits(num));
	}

	static int SumOfDigits(int num)
	{
		int sum = 0;
		while (num > 0)
		{
			sum += num % 10;
			num /= 10;
		}
		return sum;
	}
}
