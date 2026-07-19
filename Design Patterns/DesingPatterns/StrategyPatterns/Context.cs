using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DesingPatterns.StrategyPatterns
{
    
    public class Context
    {
        private IStrategy _strategy;

        public IStrategy Strategy
        {
            set { _strategy = value; } // Podemos cambiar la estrategia en tiempo de ejecución.
        }

        public  Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Run()
        {
            _strategy.Run(); // no me importa como pero tienes que hacerlo
        }
    }
}
