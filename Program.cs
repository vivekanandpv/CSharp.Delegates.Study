using System;

namespace CSharp.Delegates.Study
{
    public delegate double SquareDelegate(double n);
    public delegate double AreaOfRectangleDelegate(double l, double w);
    public delegate int RandomIntProducerDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //  implicit return when block is absent
            //  but only one statement is allowed
            SquareDelegate sd = (x) => x * x;   //  x*x is the implicit return

            //  explicit return with a block
            //  can have a proper method body with multi-line logic
            SquareDelegate sdVerbose = (x) =>
            {
                //  logic...
                return x * x;   //  return statement is required because of the block
            };

            //  parentheses not needed for one parameter
            SquareDelegate sdVerbose2 = x =>
            {
                //  logic...
                return x * x;   //  return statement is required because of the block
            };

            //  2 parameters; parentheses are required; could be a oneliner with implicit return
            AreaOfRectangleDelegate ad = (l, w) =>
            {
                //  logic...
                return l * w;
            };

            //  no parameter; empty parentheses are required
            RandomIntProducerDelegate rp = () =>
            {
                Random random = new Random();
                return random.Next(100, 1000);
            };
        }
    }
}
