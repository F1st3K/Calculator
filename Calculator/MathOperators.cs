using System.Collections.Generic;

namespace Calculator
{
    public static class MathOperators
    {
        public static readonly string LeftParenthesis  = "(";
        public static readonly string RightParenthesis  = ")";
        public static readonly Dictionary<string, int> OperationPriority = new() 
        {
            {"+", 1},
            {"-", 1},
            {"*", 2},
            {"/", 2},
            {"^", 3},
            {"~", 4}
        };
    }
}