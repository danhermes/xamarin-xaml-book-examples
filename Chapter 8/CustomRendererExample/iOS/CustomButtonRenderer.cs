using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using CustomRendererExample;
using CustomRendererExample.iOS;

[assembly: ExportRenderer (typeof (CustomButton), typeof (CustomButtonRenderer))]

namespace CustomRendererExample.iOS
{
	public class CustomButtonRenderer : ButtonRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged (e);

            		if (Control != null)
            		{
                Control.BackgroundColor = UIColor.FromRGB(50,205,50);
			}
		}
	}
}

