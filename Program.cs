using System;

namespace CSharp.Delegates.Study
{
    public delegate void PrintMessage(string message);  //  this is a type, not an object!
                                                        //  As such this is not usable!
    class Program
    {
        static void Main(string[] args)
        {
            //  creating an instance of the delegate with a static method
            PrintMessage delegateInstance1 = Foo;

            var sample = new Sample();

            //  creating an instance of the delegate with an instance method
            PrintMessage delegateInstance2 = sample.Baz;

            //  invoke the delegate
            Bar(delegateInstance1, "Good Afternoon");   //  Foo will be called
            Bar(delegateInstance2, "Good Afternoon");   //  Baz on Sample will be called
        }

        static void Foo(string m)
        {
            Console.WriteLine($"Static Implementation: {m}");
        }

        static void Bar(PrintMessage pmDelegate, string message)
        {
            //  pmDelegate.Invoke(message); //  old way
            pmDelegate(message); //  modern approach
        }
    }

    class Sample
    {
        public void Baz(string m)
        {
            Console.WriteLine($"Instance Implementation: {m}");
        }
    }
}
