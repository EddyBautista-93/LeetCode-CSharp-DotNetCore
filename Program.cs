using System.Collections.Generic;

namespace LeetCode_CSharp_DotNetCore
{
    internal class Program
    {
        // 6.28 Valid Parentheses

        // Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

        // An input string is valid if:

        // Open brackets must be closed by the same type of brackets.
        // Open brackets must be closed in the correct order.

        // Example 1:

        // Input: s = "()"
        // Output: true
        // Example 2:

        // Input: s = "()[]{}"
        // Output: true
        // Example 3:

        // Input: s = "(]"
        // Output: false
        // Example 4:

        // Input: s = "([)]"
        // Output: false
        // Example 5:

        // Input: s = "{[]}"
        // Output: true

        // Constraints:

        // 1 <= s.length <= 104
        // s consists of parentheses only '()[]{}'.

        public bool IsValid(string s)
        {
            Stack<char> endings = new Stack<char>(); // create a stack to hold reference

            foreach (var x in s) x zx 
            {
                switch (x)
                {
                    case '(':
                        endings.Push(')');
                        break;

                    case '[':
                        endings.Push(']');
                        break;

                    case '{':
                        endings.Push('}');
                        break;

                    case ')':
                    case ']':
                    case '}':
                        if (endings.Count == 0 || endings.Pop() != x)
                            return false;
                        break;
                }
            }
            return endings.Count == 0;
        }

        private static void Main(string[] args)
        {
        isValid("()") // true
        isValid("()[]{}") // true
        isValid("(]") // false 
        isValid("([)]") // false 
        isValid("{[]}") // true
        }
    }
}