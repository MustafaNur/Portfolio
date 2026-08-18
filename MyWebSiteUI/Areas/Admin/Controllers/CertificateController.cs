using Business.Interfaces;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSiteUI.Areas.Admin.Controllers;

[Area("Admin")]
public class CertificateController : Controller
{
    private readonly ICertificateService _certificateService;

    public CertificateController(ICertificateService certificateService)
    {
        _certificateService = certificateService;
    }

    public IActionResult Index() => View(_certificateService.TGetAll());

    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(Certificate model)
    {
        if (!ModelState.IsValid) return View(model);
        _certificateService.TInsert(model);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var model = _certificateService.TGetById(id);
        if (model == null) return NotFound();
        return View(model);
    }

    [HttpPost]
    public IActionResult Edit(Certificate model)
    {
        if (!ModelState.IsValid) return View(model);
        _certificateService.TUpdate(model);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var model = _certificateService.TGetById(id);
        if (model == null) return NotFound();
        _certificateService.TDelete(model);
        return RedirectToAction(nameof(Index));
    }
}
