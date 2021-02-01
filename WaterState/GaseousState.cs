using System;
using System.Collections.Generic;
using System.Text;

namespace WaterState
{
    class GaseousState : IWaterState
    {
        public void Heat(State water)
        {
            Console.WriteLine("Heat up gas");
        }

        public void Frost(State water)
        {
            Console.WriteLine("Turning gas into liquid");
            water.currentState = new LiquidState();
        }
    }
}
