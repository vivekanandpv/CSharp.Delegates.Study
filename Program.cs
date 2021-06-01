using System;

namespace CSharp.Delegates.Study
{
    public delegate void PrintMessage(string message);
    class Program
    {
        static void Main(string[] args)
        {
            //  This is the lambda expression implementation
            PrintMessage anonymousDelegate = (str) => Console.WriteLine(str);

            Bar(anonymousDelegate, "Good Afternoon");

            //  lambda expression is usually written inline
            Bar((s) => Console.WriteLine($"Lambda expression: {s}"), "Good day!");
        }

        static void Bar(PrintMessage pmDelegate, string message)
        {
            pmDelegate(message);
        }
    }
}
