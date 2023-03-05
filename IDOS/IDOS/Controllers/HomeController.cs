using System.Diagnostics;
using System.Text.Json;
using IDOS.Repositories;
using IDOS.Services;
using IDOS.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace IDOS.Controllers;

public class HomeController : Controller
{
    public StopServis ss = new StopServis();
    public IActionResult Index(string Name, int page)
    {
        List<Stop> stops = new List<Stop>();
        List<Stop> epicStops = new List<Stop>();
        ViewData["page"] = page;

        foreach (StopGroup sto in ss.r.LoadStops().StopGroups)
        {
            foreach (Stop stop in sto.Stops)
            {
                stops.Add(stop);
            }
        }

        var list = stops.Skip(page*10).ToList();
        for (int i = 0; i < 10; i++)
        {
            epicStops.Add(list.ElementAt(i));
        }
        if (!String.IsNullOrEmpty(Name))
        {
            return View(ss.Search(Name));
        }
        return View(epicStops);
    }
}