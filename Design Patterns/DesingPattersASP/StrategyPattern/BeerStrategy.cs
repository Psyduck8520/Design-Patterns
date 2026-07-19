using DesignPatterns.Repository;
using DesingPattersASP.Models.ViewModels;
using DesignPatters.Models.Data;

namespace DesingPattersASP.StrategyPattern
{
    public class BeerStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
           var Beer = new Beer
           {
               Name = beerVM.Name,
               Style = beerVM.Style,
               BrandId = (Guid)beerVM.BrandId
           };
            unitOfWork.Beers.Add(Beer);
            unitOfWork.Save(); //Se guarda en la base de datos
        }
    }
}
