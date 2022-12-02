using intentory.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace intentory.Models
{
    [Table("ProductPurchase", Schema = "public")]
    public class ProductPurchase
    {
        public long? Id { get; set; }

        public virtual Vendor Vendor { get; set; }
        public long? VendorId { get; set; }

        public virtual ProductAdd ProductAdd { get; set; }
        public long? ProductAddId { get; set; }

        

        public string MeasuringUnit { get; set; }

        public string Quantity { get; set; }

        public string PurchasePrice { get; set; }

        public string SalesPrice { get; set; }

    }
}
