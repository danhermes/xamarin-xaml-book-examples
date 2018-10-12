using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Windows.Input;

// Chapter 6 — Making a Scrollable List examples from
// Building Xamarin Mobile Apps Using XAML
// a book by Dan Hermes and Dr. Nima Mazloumi
// published by Apress and available on Amazon

// Read more about Dan Hermes at https://lexicon.systems/aboutdanhermes/
// If you need Xamarin development or consulting visit https://lexicon.systems

namespace ListViewExample.Xaml
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            BindingContext = new HomePageViewModel(Navigation);
        }
    }


    public class HomePageViewModel : BindableObject
    {

        private readonly INavigation navigation;

        public Command<string> NavigateCommand
        {
            get;
            set;
        }

        public HomePageViewModel(INavigation navigation)
        {
            this.navigation = navigation;
            NavigateCommand = new Command<string>(NagivigateRequested);
        }


        async void NagivigateRequested(string pageName)
        {
            var pageType = Type.GetType("ListViewExample.Xaml." + pageName);
            Page page = (Page)Activator.CreateInstance(pageType);
            await navigation.PushAsync(page);
        }
    }
}

