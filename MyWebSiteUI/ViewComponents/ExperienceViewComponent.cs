using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSiteUI.ViewComponents
{
    public class ExperienceViewComponent : ViewComponent
    {
        private readonly IExperienceService _experienceService;

        public ExperienceViewComponent(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Business katmanından verileri çekiyoruz
            var values = _experienceService.TGetAll();
            return View(values);
        }
    }
}
