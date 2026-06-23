using Microsoft.AspNetCore.Mvc;
using Tools.Earn;

namespace DesingPattersASP.Controllers;

public class ProductDetailController : Controller
{
    private  EarnFactory  _localEarnfactory;
    private  EarnFactory  _foreignEarnfactory;
    public  ProductDetailController(LocalEarnfactory localEarnfactory, ForeignEarnfactory foreignEarnfactory)
    {
        _localEarnfactory = localEarnfactory;
        _foreignEarnfactory = foreignEarnfactory;
    }
    // GET
    public IActionResult Index(decimal total)
    {
       
        var foreignEarn = _foreignEarnfactory.GetEarn();
        //Producto el ojeto que genera  esta 
        var localEarn  = _localEarnfactory.GetEarn(); // un objeto listo para ser utilizado
        
        ViewBag.totalLocal  = total + localEarn.Earn(total) ; // la flexibilidad que nos da el patron factory es que podemos cambiar
                                                              // la forma de calcular el earn sin alterar el codigo del controlador,
                                                              // solo cambiando la fabrica que utilizamos.
                                                              
        ViewBag.totalExtrajero = total + foreignEarn.Earn(total);
        return View();
    }
}