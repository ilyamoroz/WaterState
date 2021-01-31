using System;
using System.Collections.Generic;
using System.Text;

namespace WaterState
{
    class LiquidState : State
    {
        public override void Unfreeze()
        {
            Console.WriteLine("Unfreeze");
        }
        public override void HeatUp()
        {
            Console.WriteLine("State : Liquid");
            this._context.TransitionTo(new GaseousState());
        }
        public override void Boil()
        {
            Console.WriteLine("Boil");
        }
    }
}
