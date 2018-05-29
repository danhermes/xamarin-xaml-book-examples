using System;
using Xamarin.Forms;

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
