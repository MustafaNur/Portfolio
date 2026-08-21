using System.Diagnostics;
using Business.Interfaces;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using MyWebSiteUI.Models;

namespace MyWebSiteUI.Controllers;

public class HomeController : Controller
{
    private readonly IContactService _contactService;

    public HomeController(IContactService contactService)
    {
        _contactService = contactService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SubmitContact(Contact model)
    {
        if (string.IsNullOrWhiteSpace(model.ContactName) ||
            string.IsNullOrWhiteSpace(model.ContactEmail) ||
            string.IsNullOrWhiteSpace(model.ContactMessage))
        {
            return BadRequest(new { message = "Lütfen gerekli alanları doldurun." });
        }

        _contactService.TInsert(model);
        return Ok(new { message = "Mesajınız alındı, en kısa sürede size dönüş yapacağız." });
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
