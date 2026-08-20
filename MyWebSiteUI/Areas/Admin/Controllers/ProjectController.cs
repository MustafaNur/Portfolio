using Business.Interfaces;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSiteUI.Areas.Admin.Controllers;

[Area("Admin")]
public class ProjectController : AdminControllerBase
{
    private readonly IPortfolioService _portfolioService;

    public ProjectController(IPortfolioService portfolioService)
    {
        _portfolioService = portfolioService;
    }

    public IActionResult Index()
    {
        var values = _portfolioService.TGetAll();
        return View(values);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Portfolio portfolio)
    {
        if (!ModelState.IsValid)
        {
            return View(portfolio);
        }

        _portfolioService.TInsert(portfolio);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var portfolio = _portfolioService.TGetById(id);
        if (portfolio == null)
        {
            return NotFound();
        }

        return View(portfolio);
    }

    [HttpPost]
    public IActionResult Edit(Portfolio portfolio)
    {
        if (!ModelState.IsValid)
        {
            return View(portfolio);
        }

        _portfolioService.TUpdate(portfolio);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var portfolio = _portfolioService.TGetById(id);
        if (portfolio == null)
        {
            return NotFound();
        }

        _portfolioService.TDelete(portfolio);
        return RedirectToAction(nameof(Index));
    }
}
