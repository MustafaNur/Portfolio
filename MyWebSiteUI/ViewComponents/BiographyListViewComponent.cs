using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSiteUI.ViewComponents
{
    public class BiographyListViewComponent : ViewComponent
    {
        private readonly IBiographyService _biographyService;

        public BiographyListViewComponent(IBiographyService biographyService)
        {
            _biographyService = biographyService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Business katmanından verileri çekiyoruz
            var values = _biographyService.TGetAll();
            return View(values);
        }
    }
}