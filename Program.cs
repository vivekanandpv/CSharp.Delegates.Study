using System;

namespace CSharp.Delegates.Study
{
    //  delegate type is derived from MulticastDelegate
    //  https://docs.microsoft.com/en-us/dotnet/api/system.multicastdelegate?view=net-5.0
    //  This means, delegates inherently support multiple subscribers

    public delegate void PrintMessage(string message);  
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage delegateInstance1 = Foo;

            var sample = new Sample();

            //  creating an instance of the delegate with an instance method
            delegateInstance1 +=  sample.Baz;   //  multicasting
            delegateInstance1 +=  sample.Baz;   //  duplicate subscription is allowed
            delegateInstance1 +=  sample.Baz;
            delegateInstance1 -=  sample.Baz;   //  unsubscribe

            Bar(delegateInstance1, "Good Afternoon");
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
