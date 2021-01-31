using System;

namespace WaterState
{
    class SolidState : State
    {
        public override void Unfreeze()
        {
            Console.WriteLine("State : Solid");
            this._context.TransitionTo(new LiquidState());
        }
        public override void HeatUp()
        {
            Console.WriteLine("Heat Up");
        }
        public override void Boil()
        {
            Console.WriteLine("Boil");
        }
    }
}
