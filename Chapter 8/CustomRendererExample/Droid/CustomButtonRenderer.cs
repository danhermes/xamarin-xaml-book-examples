using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using CustomRendererExample;
using CustomRendererExample.Droid;
using Android.Content;

[assembly: ExportRenderer (typeof (CustomButton), typeof (CustomButtonRenderer))]

namespace CustomRendererExample.Droid
{
	public class CustomButtonRenderer : ButtonRenderer
	{
        public CustomButtonRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }

		protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
                Control.SetBackgroundColor (global::Android.Graphics.Color.LimeGreen);
			}
		}
	}
}