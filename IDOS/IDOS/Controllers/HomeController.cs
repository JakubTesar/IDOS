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
    public int pageReal = 1; 

    public IActionResult Index(string Name, string prev)
    {
        List<Stop> epicStops = new List<Stop>();
        if (!String.IsNullOrEmpty(prev))
        {
            if (prev.Equals("prev"))
            {
                pageReal -= 1;
            }
            else
            {
                pageReal += 1;
            }
        }

        for (int i = pageReal-1; i < ((pageReal-1)-10); i++)
        {
         epicStops.Add(ss.Search(Name).ElementAt(i));   
        }
        return View(epicStops);
    }
}