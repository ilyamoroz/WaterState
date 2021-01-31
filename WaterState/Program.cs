using System;

namespace WaterState
{
    class Program
    {
        static void Main(string[] args)
        {
            // Клиентский код.
            Context context = new Context(new SolidState());
            context.ChangeStateStage1();
            context.ChangeStateStage2();
            context.ChangeStateStage3();
        }
    }
}