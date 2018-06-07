using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutExample.Xaml.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FlexLayoutExample : ContentPage
	{
		public FlexLayoutExample ()
		{
			InitializeComponent ();
		}
	}
}