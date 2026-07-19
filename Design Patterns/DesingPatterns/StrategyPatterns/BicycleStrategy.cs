using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns.StrategyPatterns
{
    public class BicycleStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy una bicicleta y me muevo con 2 llantas");
        }
    }
}
