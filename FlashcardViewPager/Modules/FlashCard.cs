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
    public class FlashCard
    {
        public string question;

        public string answer;

        public string Question
        {
            get { return question; }
        }

        public string Answer
        {
            get { return answer; }
        }
    }
}