using System;
using System.ComponentModel;
using System.Linq;
using EffectExample.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("EffectExample")]
[assembly: ExportEffect(typeof(IOSAutoCorrectEffect), "AutoCorrectEffect")]
namespace EffectExample.iOS
{
    public class IOSAutoCorrectEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var effect = (AutoCorrectEffect) Element.Effects.FirstOrDefault(e => e is AutoCorrectEffect);
            var entry = Control as UITextField;
            if (effect.IsActive) entry.AutocorrectionType = UITextAutocorrectionType.Yes;
            else entry.AutocorrectionType = UITextAutocorrectionType.No;
        }

        protected override void OnDetached() {}

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            if (args.PropertyName == "Text")
            {
                var entry = Element as Entry;
                Console.WriteLine(entry.Text);
            }
        }
    }
}
