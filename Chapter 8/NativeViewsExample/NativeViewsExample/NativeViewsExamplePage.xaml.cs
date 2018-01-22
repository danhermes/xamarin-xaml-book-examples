using Xamarin.Forms;

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