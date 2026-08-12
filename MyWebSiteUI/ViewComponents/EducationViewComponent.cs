using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSiteUI.ViewComponents
{
    public class EducationViewComponent : ViewComponent
    {
        private readonly IEducationService _educationService;

        public EducationViewComponent(IEducationService educationService)
        {
            _educationService = educationService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Business katmanından verileri çekiyoruz
            var values = _educationService.TGetAll();
            return View(values);
        }
    }
}
