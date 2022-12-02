using System.ComponentModel.DataAnnotations.Schema;

namespace intentory.Models
{
    [Table("ProductSales", Schema = "public")]
    public class ProductSales
    {
        public long? Id { get; set; }

        public virtual Customer Customer { get; set; }
        public long? CustomerId { get; set; }

        public virtual ProductAdd ProductAdd { get; set; }
        public long ProductAddId { get; set; }


        public string MeasuringUnit { get; set; }

        public string Quantity { get; set; }

        public string SalesPrice { get; set; }





    }
}
