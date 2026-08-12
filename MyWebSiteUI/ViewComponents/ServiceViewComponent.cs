using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSiteUI.ViewComponents
{
    public class ServiceViewComponent : ViewComponent
    {
        private readonly IServiceService _serviceService;

        public ServiceViewComponent(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Business katmanından verileri çekiyoruz
            var values = _serviceService.TGetAll();
            return View(values);
        }
    }
}
