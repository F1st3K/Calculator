﻿using System.Collections.Generic;
using System.Linq;

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
                    if (i > 0 && 
                        parsedExpression[parsedExpression.Length - 1] != Separator)
                        parsedExpression += Separator;
                    parsedExpression += expression[i].ToString();
                    if (i < expression.Length-1)
                        parsedExpression += Separator;
                    continue;
                }
            }
            
            return UnaryMinusFinder.ReplaceUnaryMinus(parsedExpression.Split(Separator));
        }
    }
}