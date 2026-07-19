using DesingPatterns.FactoryPattern;
using DesingPatterns.Models;
using DesingPatterns.RepositoryPattern;
using DesingPatterns.Singleton;
using DesingPatterns.UnitOfWorkPattern;
using System;
using  DesingPatterns.StrategyPatterns;
using DesingPatterns.BuilderPattern;
namespace DesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var builder = new PreparedAlcoholicDrinkConcreteBuilder();
            
            var director = new BarmanDirector(builder);
            director.PrepareMargarita();
            var preparedDrink = builder.GetPreparedDrink();
            Console.WriteLine(preparedDrink.Result.ToString()); 
        }
    }
}
