using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SharissaWebApp.Models;

namespace SharissaWebApp.Controllers;
//links to the Program.cs file app.MapControllerRoute maps the request to 
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
//action methonds used to handle request routing to View URL 
    public IActionResult Index()
    {
        return View();
    }
// action method that routes the request to the URL 
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
