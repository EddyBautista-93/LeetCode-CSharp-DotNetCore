using System;
using System.Linq;

namespace LeetCode_CSharp_DotNetCore
{
    internal class Program
    {
        // 6.30 Highest and Lowest
        // In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.

        // Example:

        // Kata.HighAndLow("1 2 3 4 5");  // return "5 1"
        // Kata.HighAndLow("1 2 -3 4 5"); // return "5 -3"
        // Kata.HighAndLow("1 9 3 4 -5"); // return "9 -5"


        public static string HighAndLow(string numbers)
        {
            int[] intArray = numbers.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            string high = intArray.Max().ToString();
            string low = intArray.Min().ToString();
            return $"{high} {low}";
        }

        // another way from codewars
        //public static string HighAndLow(string numbers)
        //{
        //    var parsed = numbers.Split().Select(int.Parse);
        //    return parsed.Max() + " " + parsed.Min();
        //}

        private static void Main(string[] args)
        {
            HighAndLow("1 2 3 4 5");
            
        }
    }
}