using System;

namespace CSharp.Delegates.Study
{
    public delegate void PrintMessage(string message);  //  this is a type, not an object!
                                                        //  As such this is not usable!
    class Program
    {
        static void Main(string[] args)
        {
            var cardSwiper = new CardSwiper();

            //  register the listener
            cardSwiper.AmountChanged += CardSwiper_AmountChanged;


            //  set the value
            cardSwiper.CurrentAmount = 1457;
        }

        private static void CardSwiper_AmountChanged(object sender, CardSwiperEventArgs e)
        {
            Console.WriteLine($"Event handled: {e.Message}");
        }
    }
}
