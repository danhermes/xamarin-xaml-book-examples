using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CSSExample
{
    public partial class CSSPage : ContentPage
    {
        const string placeHolderText = "Type your message here";

        void HandleSubject(object sender, Xamarin.Forms.FocusEventArgs e)
        {

        }

        void HandleFeedback(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            var text = Feedback.Text;

            if (Feedback.Text == placeHolderText)
            {
                Feedback.Text = string.Empty;
                Feedback.TextColor = Color.Navy;
                return;
            }

            if (Feedback.Text == string.Empty)
            {
                Feedback.Text = placeHolderText;
                Feedback.TextColor = Color.Silver;
                return;
            }
        }

        public CSSPage()
        {
            InitializeComponent();
            Feedback.Text = placeHolderText;
            Feedback.TextColor = Color.Silver;
        }
    }
}
