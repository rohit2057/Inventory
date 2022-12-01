using intentory.data;
using intentory.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpGet]
        public IActionResult ProductGroup()
        {
            //return View();
            return View(Context.groups.ToList());
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(ProductGroupVm vm)
        {
            var viewmodel = new ProductGroup()
            {

                Name = vm.Name,
                Description = vm.Description,
                Status = "Active",
            };
            Context.groups.Add(viewmodel);
            Context.SaveChanges();

            return RedirectToAction("ProductGroup");
        }

        public IActionResult ProductGroupUpdate(long id)
        {
            ProductGroup vm = Context.groups.Find(id);
            return View(vm);
        }

        [HttpPost]
        public IActionResult ProductGroupUpdate(ProductGroup p)
        {
            Context.Entry(p).State = EntityState.Modified;
            Context.SaveChanges();
            return RedirectToAction("ProductGroup");
        }

        public IActionResult ProductGroupDelete(long id)
        {
            ProductGroup auth = Context.groups.Find(id);
            Context.Entry(auth).State = EntityState.Deleted;
            Context.SaveChanges();

            return RedirectToAction("ProductGroup");
        }

        [HttpGet]
        public IActionResult UnitOfMeasure()
        {
            return View(Context.measures.ToList());
            
        }

        public IActionResult AddMeasure()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMeasure(MeasureVm vm)
        {
            var viewmodel = new Measure()
            {

                Name = vm.Name,
                Code = vm.Code,
                Description = vm.Description,
                Status = "Active",
            };
            Context.measures.Add(viewmodel);
            Context.SaveChanges();

            return RedirectToAction("UnitOfMeasure");
        }

        public IActionResult UnitOfMeasureUpdate(long id)
        {
            Measure vm = Context.measures.Find(id);
            return View(vm);
        }

        [HttpPost]
        public IActionResult UnitOfMeasureUpdate(Measure m)
        {
            Context.Entry(m).State = EntityState.Modified;
            Context.SaveChanges();
            return RedirectToAction("UnitOfMeasure");
        }

        public IActionResult UnitOfMeasureDelete(long id)
        {
            Measure auth = Context.measures.Find(id);
            Context.Entry(auth).State = EntityState.Deleted;
            Context.SaveChanges();

            return RedirectToAction("UnitOfMeasure");
        }

        [HttpGet]
        public IActionResult Product()
        {
            return View(Context.products.ToList());
        }

        public IActionResult ProductAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProductAdd(ProductAddVm vm)
        {
            var viewmodel = new ProductAdd()
            {

                Name = vm.Name,
                Description = vm.Description,
                UnitOfMeasure = vm.UnitOfMeasure,
                Status = "Active",
            };
            Context.products.Add(viewmodel);
            Context.SaveChanges();

            return RedirectToAction("Product");
        }

        public IActionResult ProductUpdate(long id)
        {
            ProductAdd vm = Context.products.Find(id);
            return View(vm);
        }

        [HttpPost]
        public IActionResult ProductUpdate(ProductAdd p)
        {
            Context.Entry(p).State = EntityState.Modified;
            Context.SaveChanges();
            return RedirectToAction("Product");
        }

        public IActionResult ProductDelete(long id)
        {
            ProductAdd auth = Context.products.Find(id);
            Context.Entry(auth).State = EntityState.Deleted;
            Context.SaveChanges();

            return RedirectToAction("UnitOfMeasure");
        }

        [HttpGet]
        public IActionResult Vendor()
        {
            return View(Context.vendors.ToList());
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
                Status = "Active",

            };
            Context.vendors.Add(viewmodel);
            Context.SaveChanges();

            return RedirectToAction("Vendor");
        }

        public IActionResult VendorUpdate(long id)
        {
            Vendor vm = Context.vendors.Find(id);
            return View(vm);
        }

        [HttpPost]
        public IActionResult VendorUpdate(Vendor m)
        {
            Context.Entry(m).State = EntityState.Modified;
            Context.SaveChanges();
            return RedirectToAction("Vendor");
        }

        public IActionResult VendorDelete(long id)
        {
            Vendor auth = Context.vendors.Find(id);
            Context.Entry(auth).State = EntityState.Deleted;
            Context.SaveChanges();

            return RedirectToAction("UnitOfMeasure");
        }

        public IActionResult ProductPurchase()
        {
            return View();
        }

        public IActionResult ProductSales ()
        {
            return View();
        }

          public IActionResult Purchase() 
        {

            return View();
        }

        [HttpGet]
        public IActionResult Customer()
        {
            return View(Context.customers.ToList());
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
                Status = "Active",
            };
            Context.customers.Add(viewmodel);
            Context.SaveChanges();

            return RedirectToAction("Customer");
        }

        public IActionResult CustomerUpdate(long id)
        {
            Customer vm = Context.customers.Find(id);
            return View(vm);
        }

        [HttpPost]
        public IActionResult CustomerUpdate(Customer c)
        {
            Context.Entry(c).State = EntityState.Modified;
            Context.SaveChanges();
            return RedirectToAction("Customer");
        }

        public IActionResult CustomerDelete(long id)
        {
            Customer auth = Context.customers.Find(id);
            Context.Entry(auth).State = EntityState.Deleted;
            Context.SaveChanges();

            return RedirectToAction("UnitOfMeasure");
        }

    }
}
