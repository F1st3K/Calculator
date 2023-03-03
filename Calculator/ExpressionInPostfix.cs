using System.Collections.Generic;

namespace Calculator
{
    public class ExpressionInPostfix
    {
        
        
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