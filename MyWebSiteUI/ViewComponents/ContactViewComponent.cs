using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSiteUI.ViewComponents
{
    public class ContactViewComponent : ViewComponent
    {
        private readonly IContactService _contactService;

        public ContactViewComponent(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Business katmanından verileri çekiyoruz
            var values = _contactService.TGetAll();
            return View(values);
        }
    }
}
