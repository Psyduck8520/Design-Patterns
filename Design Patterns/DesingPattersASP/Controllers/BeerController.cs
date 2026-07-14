using DesignPatterns.Repository;
using DesingPattersASP.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
            return View("Index",  beers);
        }
    }
}
