using intentory.data;
using intentory.Models;
using intentory.ViewModel;
using intentory.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace intentory.Controllers
{
    public class AdminController : Controller

    {
        private readonly ILogger<AdminController> _logger;
        private ApplicationDbContext Context { get; }

        public AdminController(ILogger<AdminController> logger, ApplicationDbContext _context) 
        {
            _logger = logger;
           this.Context = _context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Product()
        {
            return View(Context.inventories.ToList());
            
        }

        public IActionResult AddProduct() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct( InventoryVm vm) 
        {
            var viewmodel = new Inventory()
            {

                Name = vm.Name,
                Code = vm.Code,
                Description = vm.Description,
                Measure = vm.Measure,
                Status= "Active",
            };
            Context.inventories.Add(viewmodel);
            Context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Purchase() 
        {

            return View();
        }

        public IActionResult AddVendor()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddVendor(VendorVm vm) 
        {
            var viewmodel = new Vendor()
            {

                Name = vm.Name,
                Description = vm.Description,
               

            };
            Context.vendors.Add(viewmodel);
            Context.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult Sales()
        {
            return View();
        }

        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(CustomerVm vm)
        {
            var viewmodel = new Customer()
            {
                Name = vm.Name,
                Description = vm.Description,
            };
            Context.customers.Add(viewmodel);
            Context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
