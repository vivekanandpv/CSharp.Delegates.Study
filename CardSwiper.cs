using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Delegates.Study
{
    //  Custom generic delegate type declaration
    public delegate void CustomEventHandler<T>(object sender, T args);
    public class CardSwiper
    {
        public event CustomEventHandler<CardSwiperEventArgs> AmountChanged;
        private int amount;

        public int CurrentAmount
        {
            get { return amount; }
            set {
                {
                    amount = value;
                    //  notify subscribers here
                    //  old way
                    //if (AmountChanged != null)
                    //{
                    //    AmountChanged(this, new CardSwiperEventArgs { Message = $"Card swiped for {amount}" });
                    //}

                    //  modern approach, using null-safety operator
                    AmountChanged?.Invoke(this, new CardSwiperEventArgs { Message = $"Card swiped for {amount}" });

                }
            }
        }

    }

    public class CardSwiperEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
