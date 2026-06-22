using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesingPattersASP.Controllers;

public class ProductDetailController : Controller
{
    // GET
    public IActionResult Index(decimal total)
    {
        //Factory
        LocalEarnfactory    localEarnfactory = new LocalEarnfactory(0.20m);
        ForeignEarnfactory  foreignEarnfactory  = new ForeignEarnfactory(0.30m, 50m);
        // Creamos nuestra segunda fabrica
        var foreignEarn = foreignEarnfactory.GetEarn();
        //Producto el ojeto que genera  esta 
        var localEarn  = localEarnfactory.GetEarn(); // un objeto listo para ser utilizado
        
        ViewBag.totalLocal  = total + localEarn.Earn(total) ; // la flexibilidad que nos da el patron factory es que podemos cambiar
                                                              // la forma de calcular el earn sin alterar el codigo del controlador,
                                                              // solo cambiando la fabrica que utilizamos.
                                                              
        ViewBag.totalExtrajero = total + foreignEarn.Earn(total);
        return View();
    }
}