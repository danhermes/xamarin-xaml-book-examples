using System;
using System.Collections.Generic;

using Xamarin.Forms;

// Chapter 8 — Custom Renderers, Effects, and Native Controls examples from 
// Building Xamarin Mobile Apps Using XAML
// a book by Dan Hermes and Dr. Nima Mazloumi
// published by Apress and available on Amazon

// Read more about Dan Hermes at https://lexicon.systems/aboutdanhermes/
// If you need Xamarin development or consulting visit https://lexicon.systems

namespace EffectExample
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            string[] myPageNames = { "Text Validator Effect", "Using Attached Property"};
            examples.ItemsSource = myPageNames;

            examples.ItemTapped += (sender, e) =>
            {
                ContentPage gotoPage;
                switch (e.Item.ToString())
                {
                    case "Text Validator Effect":
                        gotoPage = new TextValidatorEffectPage();
                        break;
                    case "Using Attached Property":
                        gotoPage = new UsingAttachedPropertyPage();
                        break;
                    default:
                        gotoPage = new TextValidatorEffectPage();
                        break;
                }
                Detail = new NavigationPage(gotoPage);
                ((ListView)sender).SelectedItem = null;
                this.IsPresented = false;
            };

            Detail = new NavigationPage(new TextValidatorEffectPage());
        }
    }
}