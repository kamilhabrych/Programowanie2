using System;
using System.IO;

namespace Programowanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0.0;
            Programowanie2.ReversePolishNotation rpn = new Programowanie2.ReversePolishNotation();
            rpn.Parse("sin(x^2+6/x)");
            result = rpn.Evaluate();

            Console.WriteLine("Original:   {0}", rpn.OriginalExpression);
            Console.WriteLine("Postfix:   {0}", rpn.PostfixExpression);
            Console.WriteLine(result);
        }
    }
}
