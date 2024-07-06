/* Check Whether a Number is Armstrong Number
*/

using System;

class Program
{
    static void Main()
    {
        int num = 153;
        if (IsArmstrong(num))
            Console.WriteLine(num + " is an Armstrong number.");
        else
            Console.WriteLine(num + " is not an Armstrong number.");
    }

    static bool IsArmstrong(int num)
    {
        int sum = 0, temp = num, digits = num.ToString().Length;
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, digits);
            temp /= 10;
        }
        return sum == num;
    }
}


