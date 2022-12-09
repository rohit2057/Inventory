using AspNetCoreHero.ToastNotification.Abstractions;
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

        private readonly INotyfService _notyf;
        public AdminController(ILogger<AdminController> logger, ApplicationDbContext _context, INotyfService notyfService) 
        {
            _logger = logger;
           this.Context = _context;
            _notyf = notyfService; 
        }

        [HttpGet]
        public IActionResult Groups()
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

            _notyf.Success("Product Group Inserted Successfully");
            return RedirectToAction("Groups");
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
            _notyf.Warning("Product Group Updated Successfully");
            return RedirectToAction("Groups");
        }

        public IActionResult ProductGroupDelete(long id)
        {
            ProductGroup auth = Context.groups.Find(id);
            Context.Entry(auth).State = EntityState.Deleted;
            Context.SaveChanges();
            _notyf.Error("Product Group Deleted Successfully");
            return RedirectToAction("Groups");
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
            _notyf.Success("Unit Of Measure Added Successfully");
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

            _notyf.Warning("Unit Of Measure Updated Successfully");
            return RedirectToAction("UnitOfMeasure");
        }

        public IActionResult UnitOfMeasureDelete(long id)
        {
            Measure auth = Context.measures.Find(id);
            Context.Entry(auth).State = EntityState.Deleted;
            Context.SaveChanges();
            _notyf.Error("Unit Of Measure Deleted Successfully");
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
            _notyf.Success("Product Added Successfully");
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
            _notyf.Warning("Product  Updated Successfully");
            return RedirectToAction("Product");
        }

        public IActionResult ProductDelete(long id)
        {
            ProductAdd auth = Context.products.Find(id);
            Context.Entry(auth).State = EntityState.Deleted;
            Context.SaveChanges();
            //_notyf.Error("Product Deleted Successfully");
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
            _notyf.Success("Vendor Added Successfully");
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
            _notyf.Warning("Vendor Updated Successfully");
            return RedirectToAction("Vendor");
        }

        public IActionResult VendorDelete(long id)
        {
            Vendor auth = Context.vendors.Find(id);
            Context.Entry(auth).State = EntityState.Deleted;
            Context.SaveChanges();
            _notyf.Error("Vendor Deleted Successfully");
            return RedirectToAction("Vendor");
        }

        public IActionResult ProductPurchase()
        {
            var vendor = new ProductPurchaseVm();

            vendor.vendorsList = Context.vendors.ToList();
            vendor.productAdd = Context.products.ToList();
            vendor.Unitofmeasure = Context.products.ToList();
            return View(vendor);
        }

        [HttpPost]
        public IActionResult ProductPurchase(ProductPurchaseVm vm)
        {
            var viewmodel = new ProductPurchase()
            {

                VendorId = vm.VendorId,
                ProductAddId = vm.ProductId,
                MeasuringUnit = vm.MeasuringUnit,
                Quantity = vm.Quantity,
                PurchasePrice = vm.PurchasePrice,
                SalesPrice = vm.SalesPrice,

            };
            Context.purchases.Add(viewmodel);
            Context.SaveChanges();
            _notyf.Success("Product Purchased Successfully");
            return RedirectToAction("Purchases");
        }

        [HttpPost]
        public IActionResult ProductSales(ProductSalesVm vm)
        {
            var viewmodel = new ProductSales()
            {

                CustomerId = vm.CustomerId,
                ProductAddId = vm.ProductId,
                MeasuringUnit = vm.MeasuringUnit,
                Quantity = vm.Quantity,
                SalesPrice = vm.SalesPrice,

            };
            Context.sales.Add(viewmodel);
            Context.SaveChanges();
            _notyf.Success("Product Sold Successfully");
            return RedirectToAction("Sales");
        }

        public IActionResult ProductSales()
        {
            var details = new ProductSalesVm();
            details.productAdd = Context.products.ToList();
            details.customerList = Context.customers.ToList();
            details.Unitofmeasure = Context.products.ToList();

            return View(details);
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
            _notyf.Success("Customer Added Successfully");
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
            _notyf.Warning("Customer Added Updated Successfully");
            return RedirectToAction("Customer");
        }

        public IActionResult CustomerDelete(long id)
        {
            Customer auth = Context.customers.Find(id);
            Context.Entry(auth).State = EntityState.Deleted;
            Context.SaveChanges();
            _notyf.Error("Customer Deleted Successfully");
            return RedirectToAction("Customer");
        }

        [HttpPost]
        public IActionResult ProductGroupStatusChange(long id)
        {
            var details = Context.groups.Find(id);
            if (details != null)
            {
                if (details.Status == "Active")
                {
                    details.Status = "Inactive";
                    Context.SaveChanges();
                    return RedirectToAction("ProductGroup");
                }
                else
                {

                    details.Status = "Active";
                    Context.SaveChanges();

                    return RedirectToAction("ProductGroup");
                }
            }
            else
            {
            }
            return RedirectToAction("ProductGroup");
        }

        [HttpPost]
        public IActionResult UnitOfMeasureStatusChange(long id)
        {
            var details = Context.measures.Find(id);
            if (details != null)
            {
                if (details.Status == "Active")
                {
                    details.Status = "Inactive";
                    Context.SaveChanges();
                    return RedirectToAction("UnitOfMeasure");
                }
                else
                {

                    details.Status = "Active";
                    Context.SaveChanges();

                    return RedirectToAction("UnitOfMeasure");
                }
            }
            else
            {
            }
            return RedirectToAction("UnitOfMeasure");
        }

        [HttpPost]
        public IActionResult ProductStatusChange(long id)
        {
            var details = Context.products.Find(id);
            if (details != null)
            {
                if (details.Status == "Active")
                {
                    details.Status = "Inactive";
                    Context.SaveChanges();
                    return RedirectToAction("Product");
                }
                else
                {

                    details.Status = "Active";
                    Context.SaveChanges();

                    return RedirectToAction("Product");
                }
            }
            else
            {
            }
            return RedirectToAction("Product");
        }

        [HttpPost]
        public IActionResult VendorStatusChange(long id)
        {
            var details = Context.vendors.Find(id);
            if (details != null)
            {
                if (details.Status == "Active")
                {
                    details.Status = "Inactive";
                    Context.SaveChanges();
                    return RedirectToAction("Vendor");
                }
                else
                {

                    details.Status = "Active";
                    Context.SaveChanges();

                    return RedirectToAction("Vendor");
                }
            }
            else
            {
            }
            return RedirectToAction("Vendor");
        }

        [HttpPost]
        public IActionResult CustomerStatusChange(long id)
        {
            var details = Context.customers.Find(id);
            if (details != null)
            {
                if (details.Status == "Active")
                {
                    details.Status = "Inactive";
                    Context.SaveChanges();
                    return RedirectToAction("Customer");
                }
                else
                {

                    details.Status = "Active";
                    Context.SaveChanges();

                    return RedirectToAction("Customer");
                }
            }
            else
            {
            }
            return RedirectToAction("Customer");
        }

        [HttpGet]
        public IActionResult Sales()
        {
            var sales = Context.sales.Include("ProductAdd").Include("Customer").ToList();
            return View(sales);
        }

        [HttpGet]
        public IActionResult Purchases()
        {
            var purchases = Context.purchases.Include("ProductAdd").Include("Vendor").ToList();
            return View(purchases);
        }


    }
}
