using Xamarin.Forms;

// Chapter 4 — Styles, Themes, and CSS examples from
// Building Xamarin Mobile Apps Using XAML
// a book by Dan Hermes and Dr. Nima Mazloumi
// published by Apress and available on Amazon

// Read more about Dan Hermes at https://lexicon.systems/aboutdanhermes/
// If you need Xamarin development or consulting visit https://lexicon.systems

namespace StyleExamples
{
    public partial class StyleExamplesPage : MasterDetailPage
    {
        public StyleExamplesPage()
        {
            InitializeComponent();

            string[] myPageNames = { "Feedback Page", "Local Design", "Static Resources", "Dynamic Resources", "Explicit Styles", "Implicit Styles", "Overriding Styles", "Using Resources in Styles","Static Style Inheritance","Dynamic Style Inheritance", "Import Resources", "Styled Feedback Page", "Light Theme", "Dark Theme", "Device Styles", "Custom Dark Theme" };
            examples.ItemsSource = myPageNames;

            examples.ItemTapped += (sender, e) =>
            {
                ContentPage gotoPage;
                switch (e.Item.ToString())
                {
                    case "Feedback Page":
                        gotoPage = new FeedbackPage();
                        break;
                    case "Local Design":
                        gotoPage = new LocalDesignPage();
                        break;
                    case "Static Resources":
                        gotoPage = new StaticResourcesPage();
                        break;
                    case "Dynamic Resources":
                        gotoPage = new DynamicResourcesPage();
                        break;
                    case "Import Resources":
                        gotoPage = new ImportResourcesPage();
                        break;
                    case "Explicit Styles":
                        gotoPage = new ExplicitStylePage();
                        break;
                    case "Implicit Styles":
                        gotoPage = new ImplicitStylePage();
                        break;
                    case "Overriding Styles":
                        gotoPage = new OverridingStylesPage();
                        break;
                    case "Using Resources in Styles":
                        gotoPage = new ButtonStylesWithResourcesPage();
                        break;
                    case "Static Style Inheritance":
                        gotoPage = new ButtonStylesWithStaticInheritancePage();
                        break;
                    case "Dynamic Style Inheritance":
                        gotoPage = new ButtonStylesWithDynamicInheritancePage();
                        break;
                    case "Styled Feedback Page":
                        gotoPage = new StylesPage();
                        break;
                    case "Light Theme":
                        gotoPage = new LightThemePage();
                        break;
                    case "Dark Theme":
                        gotoPage = new DarkThemePage();
                        break;
                    case "Device Styles":
                        gotoPage = new DeviceStylesPage();
                        break;
                    case "Custom Dark Theme":
                        gotoPage = new CustomDarkThemePage();
                        break;
                    default:
                        gotoPage = new FeedbackPage();
                        break;
                }
                Detail = new NavigationPage(gotoPage);
                ((ListView)sender).SelectedItem = null;
                this.IsPresented = false;
            };

            Detail = new NavigationPage(new FeedbackPage());
        }
    }
}
