using DesignPatterns.Repository;
using DesignPatters.Models.Data;
using DesingPattersASP.Models.ViewModels;

namespace DesingPattersASP.StrategyPattern
{
    public class BeerWithBrandStrategy : IBeerStrategy

    {
        public void Add(FormBeerViewModel beerVM, IUnitOfWork unitOfWork)
        {
            var brand = new Brand
            {
                Name = beerVM.OtherBrand,
                BrandId = Guid.NewGuid()
            };

            var beer = new Beer
            {
                Name = beerVM.Name,
                Style = beerVM.Style,
                BrandId = brand.BrandId //Se asigna el BrandId de la nueva marca a la cerveza
            };

            unitOfWork.Brands.Add(brand);
            unitOfWork.Beers.Add(beer);
            unitOfWork.Save(); //Se guarda en la base de datos
        }
    }
}
