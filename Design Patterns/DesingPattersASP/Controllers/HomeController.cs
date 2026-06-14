using System.Diagnostics;
using DesingPattersASP.Configurations;
using Microsoft.AspNetCore.Mvc;
using DesingPattersASP.Models;
using Microsoft.Extensions.Options;
using Tools;

namespace DesingPattersASP.Controllers;
using Tools;
public class HomeController : Controller
{
    private readonly IOptions<MyConfig> _config;
    public HomeController( IOptions<MyConfig> config)
    {
        _config = config;

    }
    public IActionResult Index()
    {
        
        Log.GetInstance(_config.Value.PathLog).Save("Entro a index");
        return View();
    }

    public IActionResult Privacy()
    {
        Log.GetInstance(_config.Value.PathLog).Save("Entro a privacyss");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}