using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FlashcardViewPager.Modules
{
    public class FlashCardDeck
    {
        private FlashCard[] flashCards;

        public FlashCardDeck()
        {
            flashCards = builtInFlashCards;
        }

        public FlashCard this[int i]
        {
            get { return flashCards[i]; }
        }

        public int NumCards
        {
            get { return flashCards.Length; }
        }

        static FlashCard[] builtInFlashCards = {
            new FlashCard { question = "we have been here", answer = "мы здесь (my zdes')" },
            new FlashCard { question = "we have been here already a few days" , answer = "мы здесь уже несколько дней (my zdes' uzhe neskol'ko dney)" },
            new FlashCard { question = "when did you arrive? " ,  answer = "когда ты прибыл (kogda ty pribyl)" },
            new FlashCard { question = "I arrived " , answer = "Я прибыл (YA pribyl)" },
            new FlashCard { question = "I arrived yesterday morning ", answer = "Я прибыл вчера утром (YA pribyl vchera utrom)" },
            new FlashCard { question = "my wife arrived yesterday evening ", answer = "моя жена прибыла вчера вечером (moya zhena pribyla vchera vecherom)" }
        };


    }
}