using System;
using System.Linq;
using Xamarin.Forms;

namespace EffectExample
{
    public class TextValidatorEffect2
    {
        public static readonly BindableProperty MaxLengthProperty =
            BindableProperty.CreateAttached("MaxLength", typeof(int), typeof(TextValidatorEffect2), 5, propertyChanged: MaxLengthPropertyChanged);

        public static int GetMaxLength(BindableObject view)
        {
            return (int)view.GetValue(MaxLengthProperty);
        }

        public static void SetMaxLength(BindableObject view, int value)
        {
            view.SetValue(MaxLengthProperty, value);
        }

        private static void MaxLengthPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = bindable as View;
            if (view == null) return;

            var effect = view.Effects.FirstOrDefault(e => e is TextValidatorEffect);
            if (effect != null)
            {
                view.Effects.Remove(effect);
            }
            else
            {
                effect = new TextValidatorEffect
                {
                    MaxLength = GetMaxLength(view)
                };
                view.Effects.Add(effect);
            }
        }
    }
}
