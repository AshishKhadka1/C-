/* Check Whether a Number is Prime/Composite
*/

using System;

class Program
{
    static void Main()
    {
        int num = 29;
        if (IsPrime(num))
            Console.WriteLine(num + " is a prime number.");
        else
            Console.WriteLine(num + " is a composite number.");
    }

    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
            if (num % i == 0) return false;
        return true;
    }
}
