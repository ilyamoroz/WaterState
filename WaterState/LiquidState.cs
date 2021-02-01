using System;
using System.Collections.Generic;
using System.Text;

namespace WaterState
{
    class LiquidState : IWaterState
    {
        public void Heat(State water)
        {
            Console.WriteLine("Turning liquid into gas");
            water.currentState = new GaseousState();
        }

        public void Frost(State water)
        {
            Console.WriteLine("Turning liquid into ice");
            water.currentState = new SolidState();
        }
    }
}
