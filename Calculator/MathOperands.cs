using System.Collections.Generic;

namespace Calculator
{
    public static class MathOperands
    {
        public static readonly char LeftParenthesis  = '(';
        public static readonly char RightParenthesis  = ')';
        public static readonly Dictionary<char, int> OperationPriority = new() 
        {
            {'+', 1},
            {'-', 1},
            {'*', 2},
            {'/', 2},
            {'^', 3},
            {'~', 4}
        };
    }
}