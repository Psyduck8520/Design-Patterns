using DesingPattersASP.Models.ViewModels;
using DesignPatterns.Repository;

namespace DesingPattersASP.StrategyPattern
{
    public interface IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork); //Recibe el modelo 

    }
}
