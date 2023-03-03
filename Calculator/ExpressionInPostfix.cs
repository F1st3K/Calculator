using System.Collections.Generic;
using System.ComponentModel;

namespace Calculator
{
    public class ExpressionInPostfix
    {
        public ExpressionInPostfix(string infixExpression)
        {
            InfixExpression = infixExpression;
        }

        public string[] PostfixExpression { get; private set; }

        public string InfixExpression { get; private set; }

        public void Convert()
        {
            string[] parseExpression = ExpressionParser.Parse(InfixExpression);
            UnaryMinusFinder.ReplaceUnaryMinus(parseExpression);
            var generalQueue = new Queue<string>();
            var operationStack = new Stack<string>();

            foreach (var element in parseExpression)
            {
                if (double.TryParse(element, out var number))
                {
                    generalQueue.Enqueue(element);
                    continue;
                }

                if (MathOperators.OperationPriority.ContainsKey(element))
                {
                    if (operationStack.Count == 0 ||
                        operationStack.Peek() == MathOperators.LeftParenthesis)
                    {
                        operationStack.Push(element);
                        continue;
                    }
                    if (MathOperators.OperationPriority.ContainsKey(operationStack.Peek()))
                    {
                        do
                        {
                            MathOperators.OperationPriority.TryGetValue(operationStack.Peek(), out var popPriority);
                            MathOperators.OperationPriority.TryGetValue(element, out var elementPriority);
                            if (popPriority < elementPriority )
                                break;
                            generalQueue.Enqueue(operationStack.Pop());
                        } while (operationStack.Count > 0 &&
                                 operationStack.Peek() != MathOperators.LeftParenthesis);
                        
                        operationStack.Push(element);
                        continue;
                    }
                }

                if (element == MathOperators.LeftParenthesis)
                {
                    operationStack.Push(element);
                    continue;
                }
                
                if (element == MathOperators.RightParenthesis)
                {
                    while (operationStack.Peek() != MathOperators.LeftParenthesis)
                    {
                        generalQueue.Enqueue(operationStack.Pop());
                    }

                    operationStack.Pop();
                }
            }

            while (operationStack.Count > 0)
            {
                generalQueue.Enqueue(operationStack.Pop());
            }

            PostfixExpression = new string[generalQueue.Count];
            for (int i = 0; i < PostfixExpression.Length; i++)
            {
                PostfixExpression[i] = generalQueue.Dequeue();
            }
        }
    }
}