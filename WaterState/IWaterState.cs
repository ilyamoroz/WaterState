using System;
using System.Collections.Generic;
using System.Text;

namespace WaterState
{
    interface IWaterState
    {
        void Heat(State water);
        void Frost(State water);
    }
}

