using IDOS.Repositories;
using IDOS.Services;
using IDOS.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace IDOS.Controllers;

public class Lines : Controller
{
    public LineServis ls = new LineServis();

    public StopServis ss = new StopServis();

    // GET
    public IActionResult Index(string Name, int page)
    {
        List<Line> lines = new List<Line>();
        List<Line> epicLines = new List<Line>();
        ViewData["page"] = page;

        foreach (StopGroup sto in ss.r.LoadStops().StopGroups)
        {
            foreach (Stop stop in sto.Stops)
            {
                foreach (Line line in stop.Lines)
                {
                    lines.Add(line);
                }
            }
        }

        var list = lines.Skip(page * 10).ToList();
        for (int i = 0; i < 10; i++)
        {
            epicLines.Add(list.ElementAt(i));
        }
        if (!String.IsNullOrEmpty(Name))
        {
            return View(ls.Search(Name));
        }
        return View(epicLines);
    }
}