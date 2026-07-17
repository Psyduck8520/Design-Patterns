using DesignPatterns.Repository;
using DesignPatters.Models.Data;
using DesingPattersASP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.Design;

namespace DesingPattersASP.Controllers
{
    public class BeerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BeerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork; // ya podemos utilizar el unitOfWork para acceder a los repositorios
        }
        public IActionResult Index()
        {
            IEnumerable<BeerViewModel> beers = from d in _unitOfWork.Beers.Get()
                                               select new BeerViewModel
                                               {
                                                   Id = d.BeerId,
                                                   Name = d.Name,
                                                   Style = d.Style
                                               };
            return View("Index", beers);
        }
        [HttpGet]
        public IActionResult Add()
        {
            var  brands = _unitOfWork.Brands.Get();
            ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Add(FormBeerViewModel beerVM )
        {
           if( !ModelState.IsValid) 
           {
               var brands = _unitOfWork.Brands.Get();
               ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
               return View("Add", beerVM);
           }

            var beer = new Beer();
            beer.Name = beerVM.Name;
            beer.Style = beerVM.Style;

            if(beerVM.BrandId == null)
            {
                var brand = new Brand();
                brand.Name = beerVM.OtherBrand;
                brand.BrandId = Guid.NewGuid(); // estamos  seguros que no se va repetir
                beer.BrandId = brand.BrandId;
                _unitOfWork.Brands.Add(brand);
            }
            else
            {
                beer.BrandId = (Guid)beerVM.BrandId;
            }
            _unitOfWork.Beers.Add(beer);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
