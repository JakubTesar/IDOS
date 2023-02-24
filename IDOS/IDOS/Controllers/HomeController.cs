using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;


namespace IDOS.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {
        
    }

    public IActionResult Index()
    {
        return View();
    }
    

}