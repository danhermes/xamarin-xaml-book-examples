using System;
using System.Collections.Generic;
using Xamarin.Forms;

// Chapter 9 — Local Data Access with SQLite and Data Binding examples from
// Building Xamarin Mobile Apps Using XAML
// a book by Dan Hermes and Dr. Nima Mazloumi
// published by Apress and available on Amazon

// Read more about Dan Hermes at https://lexicon.systems/aboutdanhermes/
// If you need Xamarin development or consulting visit https://lexicon.systems

namespace SQLiteNetPCL
{
	class HomePage : ContentPage
	{
        public HomePage()
		{
            Title = "SQLite.NET: Chapter 9";

			var listView = new ListView();
			listView.ItemsSource = new ListItemPage [] { 
				new ListItemPage {Title = "Basic Repository", PageType= typeof(DataAccessPageDatabase)}, 
				new ListItemPage {Title = "Advanced Repository", PageType= typeof(DataAccessPageRepository)}, 
				new ListItemPage {Title = "Access the Person Table", PageType= typeof(DataAccessPagePerson)} 
			};
			listView.ItemTemplate = new DataTemplate (typeof(TextCell));
			listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");

            listView.ItemTapped += async (sender, args) =>
            {
                var item = args.Item as ListItemPage;
                if (item == null) return;
                Page page = (Page)Activator.CreateInstance(item.PageType);
				await Navigation.PushAsync(page);
                listView.SelectedItem = null;
            };

			Content = listView;

		}

        public class ListItemPage
        {
            public string Title { get; set; }
            public Type PageType { get; set; }
        }

	} 

}

