﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HUCM_App.Models;
using HUCM_App.DbContextfile;

namespace HUCM_App.Controllers;

public class HomeController : Controller
{
    
    private readonly ILogger<HomeController> _logger;
    

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        ViewData["Title"] = "Home Manager";

    }

    public IActionResult Index()
    {
        
        return View();
    }

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