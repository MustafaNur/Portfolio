using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSiteUI.ViewComponents
{
    public class PortfolioViewComponent : ViewComponent
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioViewComponent(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Business katmanından verileri çekiyoruz
            var values = _portfolioService.TGetAll();
            return View(values);
        }
    }
}
