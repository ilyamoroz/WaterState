using System;
using System.Collections.Generic;
using System.Text;

namespace WaterState
{
    class State
    {
        public IWaterState currentState { get; set; }

        public State(IWaterState waterState)
        {
            currentState = waterState;
        }

        public void Heat()
        {
            currentState.Heat(this);
        }
        public void Frost()
        {
            currentState.Frost(this);
        }
    }
}
