using System.ComponentModel.DataAnnotations.Schema;

namespace intentory.Models
{
    [Table("ProductAdd", Schema = "public")]
    public class ProductAdd
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string UnitOfMeasure { get; set; }

        public string Status { get; set; }
    }
}
