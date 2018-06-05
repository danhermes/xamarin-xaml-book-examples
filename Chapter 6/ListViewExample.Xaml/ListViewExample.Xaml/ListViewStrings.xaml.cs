using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace ListViewExample.Xaml
{
    public partial class ListViewStrings : ContentPage
    {
        public ListViewStrings()
        {
            InitializeComponent();
            List<string> Items = new List<string>
            {
                "First",
                "Second",
                "Third"
            };

            BindingContext = Items;
        }

        async void ListViewItemTapped (object sender, ItemTappedEventArgs e)
        {
            string item = (string)e.Item;
            await DisplayAlert("Tapped", item + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }

        async void ListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string item = (string)e.SelectedItem;
            await DisplayAlert("Selected", item + " was selected.", "OK");
        }
    }
}

