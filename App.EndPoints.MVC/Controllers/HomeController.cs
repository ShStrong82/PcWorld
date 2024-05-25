using App.Domain.Core.Products.AppServices;
using App.EndPoints.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.EndPoints.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductAppService _productAppService;
        public HomeController(ILogger<HomeController> logger, IProductAppService productAppService)
        {
            _logger = logger;
            _productAppService = productAppService;
        }

        /*[Authorize(Roles = "Admin")]*/ // if some role is sign in has access to some controller

        [AllowAnonymous]
        public async Task<IActionResult> Index(int? id, CancellationToken cancellationToken)
        {
            if (id != null)
            {
                var products = await _productAppService.GetProducts(id??0, cancellationToken);
                return View(products);
            }
            else
            {
                var products = await _productAppService.GetProducts(cancellationToken);
                return View(products);
            }

        }

        [AllowAnonymous]
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
}
