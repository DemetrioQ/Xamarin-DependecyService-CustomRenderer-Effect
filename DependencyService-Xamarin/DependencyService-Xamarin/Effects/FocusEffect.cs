using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DependencyService_Xamarin.Effects
{
    public class FocusEffect : RoutingEffect
    {
        public FocusEffect() : base($"INTEC.{nameof(FocusEffect)}")
        {
        }
    }
}
