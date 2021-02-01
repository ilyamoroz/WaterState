using System;

namespace WaterState
{
    class Program
    {
        static void Main(string[] args)
        {
            // Клиентский код.
            State water = new State(new SolidState());
            int action = 0;
            
            while(action != 3){
                Console.WriteLine("1 - Heat \n2 - Frost \n3 - Exit");
                Console.Write("Select action: ");
                action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        water.Heat();
                        break;
                    case 2:
                        water.Frost();
                        break;

                }
            }
        }
    }
}