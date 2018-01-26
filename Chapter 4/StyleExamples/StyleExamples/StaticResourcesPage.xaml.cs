using Xamarin.Forms;

namespace StyleExamples
{
    public partial class StaticResourcesPage : ContentPage
    {
        void HandleFeedback(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            var placeHolderText = (string)Resources["FeedbackPlaceholder"];

            if (Feedback.Text == placeHolderText)
            {
                Feedback.Text = string.Empty;
                Feedback.TextColor = (Color)Resources["InputTextColor"];
                return;
            }

            if (Feedback.Text == string.Empty)
            {
                Feedback.Text = placeHolderText;
                Feedback.TextColor = (Color)Resources["InputPlaceholderColor"];
                return;
            }
        }

        public StaticResourcesPage()
        {
            InitializeComponent();
            Feedback.Text = (string)Resources["FeedbackPlaceholder"];
            Feedback.TextColor = (Color)Resources["InputPlaceholderColor"];
        }
    }
}
