/* Binary number to its Decimal Equivalent */


using System;

class Program
{
    static void Main()
    {
        string binary = "1010";
        Console.WriteLine("Decimal equivalent of " + binary + " is: " + BinaryToDecimal(binary));
    }

    static int BinaryToDecimal(string binary)
    {
        return Convert.ToInt32(binary, 2);
    }
}
