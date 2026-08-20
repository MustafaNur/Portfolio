using Business.Interfaces;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSiteUI.Areas.Admin.Controllers;

[Area("Admin")]
public class ExperienceController : AdminControllerBase
{
    private readonly IExperienceService _experienceService;

    public ExperienceController(IExperienceService experienceService)
    {
        _experienceService = experienceService;
    }

    public IActionResult Index() => View(_experienceService.TGetAll());

    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Experience model)
    {
        if (!ModelState.IsValid) return View(model);
        _experienceService.TInsert(model);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var model = _experienceService.TGetById(id);
        if (model == null) return NotFound();
        return View(model);
    }

    [HttpPost]
    public IActionResult Edit(Experience model)
    {
        if (!ModelState.IsValid) return View(model);
        _experienceService.TUpdate(model);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var model = _experienceService.TGetById(id);
        if (model == null) return NotFound();
        _experienceService.TDelete(model);
        return RedirectToAction(nameof(Index));
    }
}
