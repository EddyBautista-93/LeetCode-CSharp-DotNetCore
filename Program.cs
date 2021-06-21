using System;

namespace LeetCode_CSharp_DotNetCore
{
    class Program
    {
        //6.21 Palindrome LeetCode

        //Given an integer x, return true if x is palindrome integer.

        //An integer is a palindrome when it reads the same backward as forward.For example, 121 is palindrome while 123 is not.

        public static bool IsPalindrome(int a)
        {
            string inputNumber = a.ToString();
            char[] stringArray = inputNumber.ToCharArray();
            Array.Reverse(stringArray);
            string reverseInputNumber = new string(stringArray);
            return inputNumber == reverseInputNumber ? true : false;
        }
        static void Main(string[] args)
        {
            IsPalindrome(321);
        }
    }
}
