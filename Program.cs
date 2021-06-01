using System;

namespace CSharp.Delegates.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            //  most general use delegates are defined within the framework
            //  these are Action and Func
            //  They are generic

            //  Action delegate provides zero or more parameters but expects no return
            //  there are different overloads, starting from no parameter to 16 generic parameters
            //  This variant is randomly chosen
            Action<string, int, double, DateTime> action = (str, i, d, dt) =>
            {
                Console.WriteLine($"String: {str}; Int: {i}; Double: {d}; DateTime: {dt}");
            };

            //  Func delegate provides zero or more parameters (16 max) but expects a certain return value
            //  This return value type is the last generic parameter in every overload marked as TResult

            //  Here, string is the input parameter type and int is the return type
            Func<string, int> fn = (str) => str.Length;

            //  Here, 2 strings for input parameters and int as the return type
            Func<string, string, int> fn2 = (s1, s2) => (s1 + s2).Length;

            //  Predicate<T> is a specialization of Func, where the return type is bool always
            //  This has no overloads with multiple parameters
            //  In such a case, we use Func with bool as the return type

            Predicate<string> pr = (s) => s == s.ToUpper();

            //  Multi-parameter predicate must be hand-crafted from Func
            Func<int, int, int, bool> pr2 = (i, j, k) =>
            {
                return i + j >= k;
            };
        }
    }
}
