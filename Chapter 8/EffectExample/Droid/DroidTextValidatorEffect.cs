using System;
using System.ComponentModel;
using System.Linq;
using Android.Text;
using Android.Widget;
using EffectExample.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("EffectExample")]
[assembly: ExportEffect(typeof(DroidTextValidatorEffect), "TextValidatorEffect")]
namespace EffectExample.Droid
{
    public class DroidTextValidatorEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            Validate();
        }

        protected override void OnDetached() { }

        private void Validate()
        {
            var entry = Element as Entry;
            var view = Control as EditText;
            var effect = (TextValidatorEffect)Element.Effects.FirstOrDefault(e => e is TextValidatorEffect);
            if (entry.Text.Length > effect.MaxLength)
            {
                view.SetBackgroundColor(Color.Maroon.ToAndroid());
            }
            else
            {
                view.SetBackgroundColor(Color.Lime.ToAndroid());
            }
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            if (args.PropertyName == "Text") Validate();
        }
    }
}
