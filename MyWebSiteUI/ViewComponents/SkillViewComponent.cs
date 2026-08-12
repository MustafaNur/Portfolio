using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSiteUI.ViewComponents
{
    public class SkillViewComponent : ViewComponent
    {
        private readonly ISkillService _skillService;

        public SkillViewComponent(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Business katmanından verileri çekiyoruz
            var values = _skillService.TGetAll();
            return View(values);
        }
    }
}
