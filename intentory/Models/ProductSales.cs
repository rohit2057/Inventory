using System.ComponentModel.DataAnnotations.Schema;

namespace intentory.Models
{
    [Table("ProductSales", Schema = "public")]
    public class ProductSales
    {
        public long? Id { get; set; }

        public string? CustomerName { get; set; }

        public string ProductName { get; set; }

        public string MeasuringUnit { get; set; }

        public string Quantity { get; set; }

        public string SalesPrice { get; set; }

        

    }
}
