/* Check Whether a Number is Palindrome
*/

using System;

class Program
{
    static void Main()
    {
        int num = 121;
        if (IsPalindrome(num))
            Console.WriteLine(num + " is a palindrome.");
        else
            Console.WriteLine(num + " is not a palindrome.");
    }

    static bool IsPalindrome(int num)
    {
        int original = num, reversed = 0;
        while (num > 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }
        return original == reversed;
    }
}
