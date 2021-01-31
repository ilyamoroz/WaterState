using System;
using System.Collections.Generic;
using System.Text;

namespace WaterState
{
    class Context
    {
        private State _state = null;

        public Context(State state)
        {
            this.TransitionTo(state);
        }
        public void TransitionTo(State state)
        {
            Console.WriteLine($"Water: Change on {state.GetType().Name}.");
            this._state = state;
            this._state.SetContext(this);
        }
        public void ChangeStateStage1()
        {
            this._state.Unfreeze();
        }
        public void ChangeStateStage2()
        {
            this._state.HeatUp();
        }
        public void ChangeStateStage3()
        {
            this._state.Boil();
        }
    }
}
