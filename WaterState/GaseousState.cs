using System;
using System.Collections.Generic;
using System.Text;

namespace WaterState
{
    class GaseousState : State
    {
        public override void Unfreeze()
        {
            Console.WriteLine("Unfreeze");   
        }
        public override void HeatUp()
        {
            Console.WriteLine("Heat Up");
        }
        public override void Boil()
        {
            Console.WriteLine("State : Gas");
        }
    }
}
