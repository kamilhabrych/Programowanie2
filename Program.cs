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
            rpn.Parse("3*(x+2)-10/12*5");
            rpn.VariableX = 2;
            result = rpn.Evaluate();

            Console.WriteLine("Infix:  \t{0}", rpn.TransitionExpression);
            Console.WriteLine("Postfix:\t{0}", rpn.PostfixExpression);
            Console.WriteLine(result);
        }
    }
}