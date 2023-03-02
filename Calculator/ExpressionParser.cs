using System.Collections.Generic;

namespace Calculator
{
    public static class ExpressionParser
    {
        private const char Separator = '_';
        private static readonly List<char> ListMathChars = new()
        {
            '(',
            ')',
            '+',
            '-',
            '*',
            '/',
            '^',
        };

        public static string[] Parse(string expression)
        {
            var parsedExpression = string.Empty;
            for (int i = 0; i < expression.Length; i++)
            {
                if (char.IsDigit(expression[i]))
                {
                    parsedExpression += expression[i].ToString();
                    continue;
                }

                if (ListMathChars.Contains(expression[i]))
                {
                    parsedExpression += Separator.ToString() + expression[i].ToString() + Separator.ToString();
                    continue;
                }
            }
            return parsedExpression.Split(Separator);
        }
    }
}