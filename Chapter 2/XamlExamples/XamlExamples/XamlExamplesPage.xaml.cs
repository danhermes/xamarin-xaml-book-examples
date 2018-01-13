using Xamarin.Forms;

namespace XamlExamples
{
    public partial class XamlExamplesPage : MasterDetailPage
    {
        public XamlExamplesPage()
        {
            InitializeComponent();

            string[] myPageNames = { "Namespace", "Static", "Array", "Reference", "Constructors", "PropertyValues" };
            examples.ItemsSource = myPageNames;

            examples.ItemTapped += (sender, e) =>
            {
                ContentPage gotoPage;
                switch (e.Item.ToString())
                {
                    case "Namespace":
                        gotoPage = new NamespacePage();
                        break;
                    case "Static":
                        gotoPage = new StaticPage();
                        break;
                    case "Array":
                        gotoPage = new ArrayPage();
                        break;
                    case "Reference":
                        gotoPage = new ReferencePage();
                        break;
                    case "Constructors":
                        gotoPage = new ConstructorsPage();
                        break;
                    case "PropertyValues":
                        gotoPage = new PropertyValuesPage();
                        break;
                    default:
                        gotoPage = new NamespacePage();
                        break;
                }
                Detail = new NavigationPage(gotoPage);
                ((ListView)sender).SelectedItem = null;
                this.IsPresented = false;
            };

            Detail = new NavigationPage(new NamespacePage());
        }
    }
}
