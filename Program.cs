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
            rpn.Parse("3+4*2/(1-5)^2^3");
            result = rpn.Evaluate();
            Console.WriteLine("orig:   {0}", rpn.OriginalExpression);
            Console.WriteLine("tran:   {0}", rpn.TransitionExpression);
            Console.WriteLine("post:   {0}", rpn.PostfixExpression);
            Console.WriteLine("result: {0}", result);
        }
    }
}
