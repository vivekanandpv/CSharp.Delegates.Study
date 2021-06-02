using System;
using System.Collections.Generic;

namespace CSharp.Delegates.Study
{
    class Program
    {
        private static Func<int> fn;

        static void Main(string[] args)
        {
            int i = 1;

            //  this lambda expression closes over the variable declared in the outer scope
            //  this property is called closure
            //  https://en.wikipedia.org/wiki/Closure_(computer_programming)
            //  lambda expression holds on to this i
            fn = () =>
                {
                    ++i;
                    return i;
                };

            PrintResult();

            //  i kept on modifying through lambda expression invocations
            //  we see the final result here (11)
            Console.WriteLine($"After PrintResult in Main: {i}");
        }

        static void PrintResult()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Print Result - Closure: {fn()}");
            }
        }
    }
}
