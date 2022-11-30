using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace intentory.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }

        public IActionResult AddProduct() 
        {
            return View();
        }

        public IActionResult Purchase() 
        {

            return View();
        }

        public IActionResult Sales() 
        {
            return View();
        }

        public IActionResult AddVendor() 
        {
            return View();
        }

        public IActionResult AddCustomer()
        {
            return View();
        }
    }
}
