using DesingPattersASP.Models.ViewModels;
using DesignPatterns.Repository;

namespace DesingPattersASP.StrategyPattern
{
    public class BeerContext
    {
        private IBeerStrategy _strategy;

        public IBeerStrategy Strategy
        {
            set { _strategy = value; }
        }// cambio para el tiempo de ejecucion 
        public BeerContext(IBeerStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            _strategy.Add(beerVM, unitOfWork);
        }
    }
}
