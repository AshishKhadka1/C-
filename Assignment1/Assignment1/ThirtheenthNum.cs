/* Convert a decimal number to its binary Equivalent */


using System;

class Program
{
    static void Main()
    {
        int num = 10;
        Console.WriteLine("Binary equivalent of " + num + " is: " + DecimalToBinary(num));
    }

    static string DecimalToBinary(int num)
    {
        return Convert.ToString(num, 2);
    }
}
