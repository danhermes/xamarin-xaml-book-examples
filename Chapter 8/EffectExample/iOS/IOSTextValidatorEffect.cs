using System;
using System.ComponentModel;
using System.Linq;
using EffectExample.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("EffectExample")]
[assembly: ExportEffect(typeof(IOSTextValidatorEffect), "TextValidatorEffect")]
namespace EffectExample.iOS
{
    public class IOSTextValidatorEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            Validate();
        }

        protected override void OnDetached() {}

        private void Validate()
        {
            var entry = Element as Entry;
            var view = Control as UITextField;
            var effect = (TextValidatorEffect)Element.Effects.FirstOrDefault(e => e is TextValidatorEffect);
            if (entry.Text.Length > effect.MaxLength)
            {
                view.BackgroundColor = Color.FromHex("#f9c5c9").ToUIColor();
            }
            else
            {
                view.BackgroundColor = Color.FromHex("#c5f9e1").ToUIColor();
            }
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            if (args.PropertyName == "Text") Validate();
        }
    }
}
