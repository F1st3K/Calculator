using Calculator.CalculatorFromPostfix;
using Calculator.ConverterInPostfix;

namespace Calculator
{
    public class Calculator
    {
        private ExpressionInPostfix _postfixConverter;
        private PostfixCalculator _postfixCalculator;

        public Calculator()
        {
            _postfixConverter = new ExpressionInPostfix();
            _postfixCalculator = new PostfixCalculator();
        }

        public string InfixExpression { get; private set; }
        
        public string PosfixExpression { get; private set; }
        
        public double Result { get; private set; }

        public void Calculate(string expression)
        {
            InfixExpression = expression;
            _postfixConverter.Convert(InfixExpression);
            PosfixExpression = _postfixConverter.PostfixString;
            _postfixCalculator.Calculate(_postfixConverter.PostfixExpression);
            Result = _postfixCalculator.Result;
        }
    }
}