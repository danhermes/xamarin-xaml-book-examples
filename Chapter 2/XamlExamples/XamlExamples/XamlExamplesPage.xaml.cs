using Xamarin.Forms;

// Chapter 2 — Building Xamarin.Forms Apps Using XAML examples from
// Building Xamarin Mobile Apps Using XAML
// a book by Dan Hermes and Dr. Nima Mazloumi
// published by Apress and available on Amazon

// Read more about Dan Hermes at https://lexicon.systems/aboutdanhermes/
// If you need Xamarin development or consulting visit https://lexicon.systems

namespace XamlExamples
{
    public partial class XamlExamplesPage : MasterDetailPage
    {
        public XamlExamplesPage()
        {
            InitializeComponent();

            string[] myPageNames = { "Namespace", "Static", "Array", "Reference", "Constructors", "Property Values" };
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
                    case "Property Values":
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
