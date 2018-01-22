using System;
using System.ComponentModel;
using System.Linq;
using Android.Text;
using Android.Widget;
using EffectExample.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("EffectExample")]
[assembly: ExportEffect(typeof(DroidAutoCorrectEffect), "AutoCorrectEffect")]
namespace EffectExample.Droid
{
    public class DroidAutoCorrectEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var effect = (AutoCorrectEffect)Element.Effects.FirstOrDefault(e => e is AutoCorrectEffect);
            var entry = Control as EditText;
            if (effect.IsActive) entry.InputType = entry.InputType | InputTypes.TextFlagAutoCorrect;
            else entry.InputType = entry.InputType | InputTypes.TextFlagNoSuggestions;
        }

        protected override void OnDetached() { }

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
