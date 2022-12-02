using System.ComponentModel.DataAnnotations.Schema;

namespace intentory.Models
{
    [Table("ProductPurchase", Schema = "public")]
    public class ProductPurchase
    {
        public long? Id { get; set; }

        public string VendorName { get; set; }

        public string ProductName { get; set; }

        public string MeasuringUnit { get; set; }

        public string Quantity { get; set; }

        public string PurchasePrice { get; set; }

        public string SalesPrice { get; set; }

    }
}
