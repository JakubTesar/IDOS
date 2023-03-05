using IDOS.Repositories;
using IDOS.Services;
using Microsoft.AspNetCore.Mvc;

namespace IDOS.Controllers;

public class Lines : Controller
{
    public LineServis ls = new LineServis();
    // GET
    public IActionResult Index(string Name)
    {
        return View(ls.Search(Name));
    }
}