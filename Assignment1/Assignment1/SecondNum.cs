
/*Swap Two Numbers Without Using Third Variable
*/
using System;

class SecondNum
{
    static void Main()
    {
        int a = 5, b = 10;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After swapping: a = " + a + ", b = " + b);
    }
}

