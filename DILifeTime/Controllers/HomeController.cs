﻿using DILifeTime.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DILifeTime.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ITransientService _transientService1;
    private readonly ITransientService _transientService2;
    private readonly IScopedService _scopedService1;
    private readonly IScopedService _scopedService2;
    private readonly ISingletonService _singletonService1;
    private readonly ISingletonService _singletonService2;

    public HomeController(ILogger<HomeController> logger,
        ITransientService transientService1, ITransientService transientService2,
        IScopedService scopedService1,IScopedService scopedService2,
        ISingletonService singletonService1, ISingletonService singletonService2)
    {
        _logger = logger;
        _transientService1 = transientService1;
        _transientService2 = transientService2;
        _scopedService1 = scopedService1;
        _scopedService2 = scopedService2;
        _singletonService1 = singletonService1;
        _singletonService2 = singletonService2;
    }

    public IActionResult Index()
    {
        ViewBag.transient1 = _transientService1.GetRandomId().ToString();
        ViewBag.transient2 = _transientService2.GetRandomId().ToString();
        ViewBag.scoped1 = _scopedService1.GetRandomId().ToString();
        ViewBag.scoped2 =  _scopedService2.GetRandomId().ToString();
        ViewBag.singleton1 = _singletonService1.GetRandomId().ToString();
        ViewBag.singleton2 = _singletonService2.GetRandomId().ToString();
        return View();
    }
}
