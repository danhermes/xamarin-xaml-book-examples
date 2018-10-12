using System;
using Xamarin.Forms;

// Chapter 8 — Custom Renderers, Effects, and Native Controls examples from
// Building Xamarin Mobile Apps Using XAML
// a book by Dan Hermes and Dr. Nima Mazloumi
// published by Apress and available on Amazon

// Read more about Dan Hermes at https://lexicon.systems/aboutdanhermes/
// If you need Xamarin development or consulting visit https://lexicon.systems

namespace CustomRendererExample
{
    public partial class CustomRendererExamplePage : ContentPage
    {
        public CustomRendererExamplePage()
        {
            InitializeComponent();
        }

        public void ButtonClicked(object sender, EventArgs args)
        {
            DisplayAlert("Congratulations", "This button was rendered in a platform-specific class.", "OK");
        }
    }
}
