using Business.Interfaces;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSiteUI.Areas.Admin.Controllers;

[Area("Admin")]
public class EducationController : AdminControllerBase
{
    private readonly IEducationService _educationService;

    public EducationController(IEducationService educationService)
    {
        _educationService = educationService;
    }

    public IActionResult Index() => View(_educationService.TGetAll());

    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Education model)
    {
        if (!ModelState.IsValid) return View(model);
        _educationService.TInsert(model);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var model = _educationService.TGetById(id);
        if (model == null) return NotFound();
        return View(model);
    }

    [HttpPost]
    public IActionResult Edit(Education model)
    {
        if (!ModelState.IsValid) return View(model);
        _educationService.TUpdate(model);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var model = _educationService.TGetById(id);
        if (model == null) return NotFound();
        _educationService.TDelete(model);
        return RedirectToAction(nameof(Index));
    }
}
