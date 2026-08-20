using Business.Interfaces;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSiteUI.Areas.Admin.Controllers;

[Area("Admin")]
public class SkillController : AdminControllerBase
{
    private readonly ISkillService _skillService;

    public SkillController(ISkillService skillService)
    {
        _skillService = skillService;
    }

    public IActionResult Index() => View(_skillService.TGetAll());

    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Skill model)
    {
        if (!ModelState.IsValid) return View(model);
        _skillService.TInsert(model);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var model = _skillService.TGetById(id);
        if (model == null) return NotFound();
        return View(model);
    }

    [HttpPost]
    public IActionResult Edit(Skill model)
    {
        if (!ModelState.IsValid) return View(model);
        _skillService.TUpdate(model);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var model = _skillService.TGetById(id);
        if (model == null) return NotFound();
        _skillService.TDelete(model);
        return RedirectToAction(nameof(Index));
    }
}
