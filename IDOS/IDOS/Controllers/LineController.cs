using IDOS.Services;
using IDOS.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IDOS.Controllers;

public class LineController : Controller
{
    public IActionResult Index(int ID)
    {
        Line line = new Line();
        line.getStopsByLine(ID);
        return View(line);
    }
}