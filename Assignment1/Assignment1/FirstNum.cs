/*Swap Two Numbers Using Third Variable
*/
using System;

class FirstNum
{
    static void Main()
    {
        int a = 5, b = 10, temp;
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("After swapping: a = " + a + ", b = " + b);
    }
}
