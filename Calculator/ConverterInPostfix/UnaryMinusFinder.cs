namespace Calculator.ConverterInPostfix
{
    internal static class UnaryMinusFinder
    {
        public const char UnaryMinus = '~';
        
        private const char Minus = '-';
        private const char LeftParenthesis = '(';

        public static string[] ReplaceUnaryMinus(string[] expression)
        {
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == Minus.ToString() &&
                    (i == 0 || expression[i - 1] == LeftParenthesis.ToString()))
                {
                    expression[i] = UnaryMinus.ToString();
                }
            }
            return expression;
        }
    }
}