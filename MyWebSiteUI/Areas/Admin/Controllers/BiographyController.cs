using Business.Interfaces;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSiteUI.Areas.Admin.Controllers;

[Area("Admin")]
public class BiographyController : AdminControllerBase
{
    private readonly IBiographyService _biographyService;

    public BiographyController(IBiographyService biographyService)
    {
        _biographyService = biographyService;
    }

    public IActionResult Index()
    {
        return View(_biographyService.TGetAll());
    }

    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Biography model)
    {
        if (!ModelState.IsValid) return View(model);
        _biographyService.TInsert(model);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var model = _biographyService.TGetById(id);
        if (model == null) return NotFound();
        return View(model);
    }

    [HttpPost]
    public IActionResult Edit(Biography model)
    {
        if (!ModelState.IsValid) return View(model);
        _biographyService.TUpdate(model);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var model = _biographyService.TGetById(id);
        if (model == null) return NotFound();
        _biographyService.TDelete(model);
        return RedirectToAction(nameof(Index));
    }
}
