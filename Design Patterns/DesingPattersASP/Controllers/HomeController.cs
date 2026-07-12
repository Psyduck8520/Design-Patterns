using System.Diagnostics;
using DesingPattersASP.Configurations;
using Microsoft.AspNetCore.Mvc;
using DesingPattersASP.Models;
using Microsoft.Extensions.Options;
using Tools;

namespace DesingPattersASP.Controllers;

using DesignPatterns.Repository;
using DesignPatters.Models.Data;
using Tools;
public class HomeController : Controller
{
    private readonly IOptions<MyConfig> _config;
    private readonly IRepostory<Beer> repostory;
    public HomeController( IOptions<MyConfig> config, IRepostory<Beer> repostory)
    {
        _config = config;
        this.repostory = repostory;
    }
    public IActionResult Index()
    {
        
        Log.GetInstance(_config.Value.PathLog).Save("Entro a index");
        IEnumerable<Beer> lst = repostory.Get();
        return View("Index",lst);
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