using intentory.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace intentory.Models
{
    
    public class ProductPurchaseVm
    {
        public long? Id { get; set; }

        public long? VendorId { get; set; }

        public long? ProductId { get; set; }

        public string MeasuringUnit { get; set; }

        public string Quantity { get; set; }

        public string PurchasePrice { get; set; }

        public string SalesPrice { get; set; }

        public List<ProductPurchase> purchases { get; set; }

        public List<Vendor> vendorsList { get; set; }

        public SelectList vendorlistOption() => new SelectList(vendorsList, nameof(Vendor.Id), nameof(Vendor.Name));

        public List<ProductAdd> productAdd { get; set; }

        public SelectList ProductlistOption() => new SelectList(productAdd, nameof(ProductAdd.Id), nameof(ProductAdd.Name));

        public List<ProductAdd> Unitofmeasure { get; set; }

        public SelectList UnitlistOption() => new SelectList(Unitofmeasure, nameof(ProductAdd.Id), nameof(ProductAdd.UnitOfMeasure));

        public ProductAddVm products { get; set; }
        public VendorVm vendors { get; set; }
    }
}
