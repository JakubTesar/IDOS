using IDOS.Services;
using Microsoft.AspNetCore.Mvc;

namespace IDOS.Controllers;

public class StopController : Controller
{
    private StopServis SS = new StopServis();

    // GET
    public IActionResult Index(string ID)
    {
        return View(SS.Filter(ID));
    }

    
}