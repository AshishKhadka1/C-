
/*Swap Two Strings Without Using Third Variable
*/
using System;

class ThirdNum
{
    static void Main()
    {
        string str1 = "Hello", str2 = "World";
        str1 = str1 + str2;
        str2 = str1.Substring(0, str1.Length - str2.Length);
        str1 = str1.Substring(str2.Length);
        Console.WriteLine("After swapping: str1 = " + str1 + ", str2 = " + str2);
    }
}
