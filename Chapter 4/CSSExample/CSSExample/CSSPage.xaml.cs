using System;
using System.Collections.Generic;
using Xamarin.Forms;

// Chapter 4 — Styles, Themes, and CSS examples from
// Building Xamarin Mobile Apps Using XAML
// a book by Dan Hermes and Dr. Nima Mazloumi
// published by Apress and available on Amazon

// Read more about Dan Hermes at https://lexicon.systems/aboutdanhermes/
// If you need Xamarin development or consulting visit https://lexicon.systems

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
