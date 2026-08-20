using Business.Interfaces;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSiteUI.Areas.Admin.Controllers;

[Area("Admin")]
public class ContactController : AdminControllerBase
{
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
        _contactService = contactService;
    }

    public IActionResult Index() => View(_contactService.TGetAll());

    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Contact model)
    {
        if (!ModelState.IsValid) return View(model);
        _contactService.TInsert(model);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var model = _contactService.TGetById(id);
        if (model == null) return NotFound();
        return View(model);
    }

    [HttpPost]
    public IActionResult Edit(Contact model)
    {
        if (!ModelState.IsValid) return View(model);
        _contactService.TUpdate(model);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var model = _contactService.TGetById(id);
        if (model == null) return NotFound();
        _contactService.TDelete(model);
        return RedirectToAction(nameof(Index));
    }
}
