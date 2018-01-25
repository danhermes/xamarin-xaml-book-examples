using System;
using Xamarin.Forms;

namespace EffectExample
{
    public class TextValidatorEffect : RoutingEffect
    {
        public int MaxLength { get; set; } = 5;
        public TextValidatorEffect() : base("EffectExample.TextValidatorEffect") { }
    }
}
