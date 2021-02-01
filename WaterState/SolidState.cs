using System;

namespace WaterState
{
    class SolidState : IWaterState
    {
        public void Heat(State water)
        {
            Console.WriteLine("Turning ice into liquid");
            water.currentState = new LiquidState();
        }

        public void Frost(State water)
        {
            Console.WriteLine("Freeze ice");
        }
    }
}
