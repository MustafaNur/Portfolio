using Business.Interfaces;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSiteUI.Areas.Admin.Controllers;

[Area("Admin")]
public class ServiceController : AdminControllerBase
{
    private readonly IServiceService _serviceService;

    public ServiceController(IServiceService serviceService)
    {
        _serviceService = serviceService;
    }

    public IActionResult Index() => View(_serviceService.TGetAll());

    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Service model)
    {
        if (!ModelState.IsValid) return View(model);
        _serviceService.TInsert(model);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var model = _serviceService.TGetById(id);
        if (model == null) return NotFound();
        return View(model);
    }

    [HttpPost]
    public IActionResult Edit(Service model)
    {
        if (!ModelState.IsValid) return View(model);
        _serviceService.TUpdate(model);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var model = _serviceService.TGetById(id);
        if (model == null) return NotFound();
        _serviceService.TDelete(model);
        return RedirectToAction(nameof(Index));
    }
}
