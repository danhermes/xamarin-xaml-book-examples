using System;
using Xamarin.Forms;

namespace EffectExample
{
    public class AutoCorrectEffect : RoutingEffect
    {
        public bool IsActive { get; set; } = true;
        public AutoCorrectEffect() : base("EffectExample.AutoCorrectEffect") { }
    }
}
