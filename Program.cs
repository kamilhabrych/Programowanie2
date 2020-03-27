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
            rpn.Parse("3*(x+2)-10*23/12");
            result = rpn.Evaluate();

            Console.WriteLine("Original:   {0}", rpn.OriginalExpression);
            Console.WriteLine("Transition:   {0}", rpn.TransitionExpression);
            Console.WriteLine("Postfix:   {0}", rpn.PostfixExpression);
            Console.WriteLine("Result: {0}", result);
        }
    }
}
