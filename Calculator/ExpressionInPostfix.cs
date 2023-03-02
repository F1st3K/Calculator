using System.Collections.Generic;

namespace Calculator
{
    public class ExpressionInPostfix
    {
        private Dictionary<char, int> _operationPriority = new() 
        {
            {'(', 0},
            {'+', 1},
            {'-', 1},
            {'*', 2},
            {'/', 2},
            {'^', 3},
            {'~', 4}
        };
        
        public ExpressionInPostfix(string infixExpression)
        {
            InfixExpression = infixExpression;
            Convert();
        }

        public string PostfixExpression { get; private set; }

        public string InfixExpression { get; private set; }

        private void Convert()
        {
            
        }
    }
}