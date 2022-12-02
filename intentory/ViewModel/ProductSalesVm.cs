using intentory.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace intentory.Models
{

    public class ProductSalesVm
    {
        public long? Id { get; set; }

        public long? CustomerId { get; set; }

        public long ProductId { get; set; }

        public string MeasuringUnit { get; set; }

        public string Quantity { get; set; }

        public string SalesPrice { get; set; }

        public List<ProductSales> Sales { get; set; }

        public List<Customer> customerList { get; set; }

        public SelectList customerlistOption() => new SelectList(customerList, nameof(Customer.Id), nameof(Customer.Name));

        public List<ProductAdd> productAdd { get; set; }

        public SelectList ProductlistOption() => new SelectList(productAdd, nameof(ProductAdd.Id), nameof(ProductAdd.Name));

        public List<ProductAdd> Unitofmeasure { get; set; }

        public SelectList UnitlistOption() => new SelectList(Unitofmeasure, nameof(ProductAdd.Id), nameof(ProductAdd.UnitOfMeasure));

        public ProductAddVm products { get; set; }
        public CustomerVm customers { get; set; }
    }
}
