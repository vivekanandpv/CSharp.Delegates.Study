using System;

namespace CSharp.Delegates.Study
{
    public delegate void PrintMessage(string message);
    class Program
    {
        static void Main(string[] args)
        {
            //  this is anonymous function implementation
            //  Lambda expressions emerge from this point
            //  note the delegate keyword use in other context
            PrintMessage anonymousDelegate = delegate (string str)
            {
                Console.WriteLine($"Anonymous function delegate executing: {str}");
            };

            Bar(anonymousDelegate, "Good Afternoon");
        }

        static void Bar(PrintMessage pmDelegate, string message)
        {
            pmDelegate(message);
        }
    }
}
