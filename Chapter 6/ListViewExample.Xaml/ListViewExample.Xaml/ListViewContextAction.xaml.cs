using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace ListViewExample.Xaml
{
    public partial class ListViewContextAction : ContentPage
    {
        public ListViewContextAction()
        {
            InitializeComponent();

            List<ListItem> ListItems = new List<ListItem> {
                new ListItem {Title = "First", Description="1st item", Price="$100.00"},
                new ListItem {Title = "Second", Description="2nd item", Price="$200.00"},
                new ListItem {Title = "Third", Description="3rd item", Price="$300.00"}
            };

            ContextList.ItemsSource = ListItems;
        }

        public async void MoreClicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var item = (ListItem)(mi.CommandParameter);
            await DisplayAlert("Clicked", item.Title.ToString() + " More button was clicked", "OK");
        }

        public async void DeleteClicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            var item = (ListItem)mi.CommandParameter;
            await DisplayAlert("Clicked", item.Title.ToString() + " Delete button was clicked", "OK");
        }

        public class ListItem
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
        }
    }
  
}

