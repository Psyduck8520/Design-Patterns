using DesingPatterns.FactoryPattern;
using DesingPatterns.Models;
using DesingPatterns.RepositoryPattern;
using DesingPatterns.Singleton;
using DesingPatterns.UnitOfWorkPattern;
using System;
using  DesingPatterns.StrategyPatterns;
namespace DesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            var context  = new Context(new CarStrategy()); // aki estamos mandando la estrategia de carro 
            
            context.Run(); // aki estamos ejecutando la estrategia de carro
            context.Strategy  = new MotoStrategy();
            context.Run(); // aki estamos ejecutando la estrategia de moto

            //Principio de responsabilidad unica
            //Abierto cerrado, una clase abierta a extension pero cerrada a modificacion
            // cumple los principios solidos de diseño de software, que son un conjunto
            // de principios que ayudan a los desarrolladores a crear software más mantenible y escalable.

            context.Strategy = new BicycleStrategy();
            context.Run(); // aki estamos ejecutando la estrategia de bicicleta.
        }
    }
}
