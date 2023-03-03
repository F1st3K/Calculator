using System;
using System.Collections.Generic;
using Calculator.ConverterInPostfix;

namespace Calculator.CalculatorFromPostfix
{
    internal class PostfixCalculator
    {
        public double Result { get; private set; }
        
        public void Calculate(string[] postfixExpression)
        {
            var resultStack = new Stack<double>();
            for (int i = 0; i < postfixExpression.Length; i++)
            {
                double result;
                
                if (double.TryParse(postfixExpression[i], out result))
                {
                    resultStack.Push(result);
                    continue;
                }

                if (MathOperators.OperationPriority.ContainsKey(postfixExpression[i]))
                {
                    if (postfixExpression[i] == UnaryMinusFinder.UnaryMinus.ToString())
                    {
                        result = resultStack.Count > 0 ?  -resultStack.Pop() : 0;
                    }
                    else
                    {
                        if (resultStack.Count < 2)
                            throw new ArgumentException("a little operands");
                        result = Execute(postfixExpression[i], resultStack.Pop(), resultStack.Pop());
                    }
                    resultStack.Push(result);
                    continue;
                }
            }

            Result = resultStack.Pop();
        }

        private double Execute(string op, double b, double a)
            => op switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => a / b,
                "^" => Math.Pow(a, b),
                _ => 0
            };
    }
}