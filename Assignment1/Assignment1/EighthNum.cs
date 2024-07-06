/* Check Whether a String is Palindrome
*/

using System;

class Program
{
    static void Main()
    {
        string str = "madam";
        if (IsPalindrome(str))
            Console.WriteLine(str + " is a palindrome.");
        else
            Console.WriteLine(str + " is not a palindrome.");
    }

    static bool IsPalindrome(string str)
    {
        int len = str.Length;
        for (int i = 0; i < len / 2; i++)
            if (str[i] != str[len - i - 1]) return false;
        return true;
    }
}
