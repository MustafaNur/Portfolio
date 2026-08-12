using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MyWebSiteUI.ViewComponents
{
    public class CertificateViewComponent : ViewComponent
    {
        private readonly ICertificateService _certificateService;

        public CertificateViewComponent(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Business katmanından verileri çekiyoruz
            var values = _certificateService.TGetAll();
            return View(values);
        }
    }
}
