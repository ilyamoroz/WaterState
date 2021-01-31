using System;
using System.Collections.Generic;
using System.Text;

namespace WaterState
{
    abstract class State
    {
        protected Context _context;
        public void SetContext(Context context)
        {
            this._context = context;
        }
        public abstract void Unfreeze();

        public abstract void HeatUp();

        public abstract void Boil();
    }
}
