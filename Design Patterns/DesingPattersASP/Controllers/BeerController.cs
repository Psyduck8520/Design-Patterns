using DesignPatterns.Repository;
using DesignPatters.Models.Data;
using DesingPattersASP.Models.ViewModels;
using DesingPattersASP.StrategyPattern;
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
            GetBrandsData();
            return View();
        }
        [HttpPost]
        public IActionResult Add(FormBeerViewModel beerVM )
        {
           if( !ModelState.IsValid) 
           {
               GetBrandsData();
               return View("Add", beerVM);
           }

            var context = beerVM.BrandId == null?
                new BeerContext(new BeerWithBrandStrategy()):
                new BeerContext(new BeerStrategy());
            context.Add(beerVM, _unitOfWork);
            return RedirectToAction("Index");
        }

        #region     HELPER METHODS
        private void  GetBrandsData() // solicitud para ob
        {
            var brands = _unitOfWork.Brands.Get();
            ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
        }

        #endregion




    }
}
