using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

// Chapter 1 — Building Apps Using Xamarin examples from
// Building Xamarin Mobile Apps Using XAML
// a book by Dan Hermes and Dr. Nima Mazloumi
// published by Apress and available on Amazon

// Read more about Dan Hermes at https://lexicon.systems/aboutdanhermes/
// If you need Xamarin development or consulting visit https://lexicon.systems

namespace FormsExample
{
	public partial class ContentPageExample : ContentPage
	{
		public ContentPageExample ()
		{
			InitializeComponent ();
		}

		protected void ButtonClicked(object sender, EventArgs e) {

			((Button)sender).Text = "It is so!";
		}

		async protected void ImageTapped(object sender, EventArgs e) {

			Image image = ((Image)sender);

			image.Opacity = .5;
			await Task.Delay(200);
			image.Opacity = 1;
		}
	}
}
