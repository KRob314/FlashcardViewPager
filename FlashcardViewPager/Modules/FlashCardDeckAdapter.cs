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
using Android.Support.V4.App;

namespace FlashcardViewPager.Modules
{
    public class FlashCardDeckAdapter : FragmentPagerAdapter
    {
        public FlashCardDeck flashCardDeck;

        public FlashCardDeckAdapter(Android.Support.V4.App.FragmentManager fm, FlashCardDeck flashCards): base(fm)
        {
            this.flashCardDeck = flashCards;
        }

        public override int Count { get { return flashCardDeck.NumCards; } }

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            return (Android.Support.V4.App.Fragment) FlashCardFragment.newInstance(flashCardDeck[position].Question, flashCardDeck[position].Answer);
        }

        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String("Question " + (position + 1));
        }
    }
}