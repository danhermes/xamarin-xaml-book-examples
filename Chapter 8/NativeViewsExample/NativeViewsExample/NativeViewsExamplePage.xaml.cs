using Xamarin.Forms;

// Chapter 8 — Custom Renderers, Effects, and Native Controls examples from 
// Building Xamarin Mobile Apps Using XAML
// a book by Dan Hermes and Dr. Nima Mazloumi
// published by Apress and available on Amazon

// Read more about Dan Hermes at https://lexicon.systems/aboutdanhermes/
// If you need Xamarin development or consulting visit https://lexicon.systems

namespace NativeViewsExample
{
    public partial class NativeViewsExamplePage : MasterDetailPage
    {
        public NativeViewsExamplePage()
        {
            InitializeComponent();

            string[] myPageNames = { "Native View Declaration", "Using Factory Methods" };
            examples.ItemsSource = myPageNames;

            examples.ItemTapped += (sender, e) =>
            {
                ContentPage gotoPage;
                switch (e.Item.ToString())
                {
                    case "Native View Declaration":
                        gotoPage = new NativeViewsPage();
                        break;
                    case "Using Factory Methods":
                        gotoPage = new FactoryMethodsPage();
                        break;
                    default:
                        gotoPage = new NativeViewsPage();
                        break;
                }
                Detail = new NavigationPage(gotoPage);
                ((ListView)sender).SelectedItem = null;
                this.IsPresented = false;
            };

            Detail = new NavigationPage(new NativeViewsPage());
        }
    }
}