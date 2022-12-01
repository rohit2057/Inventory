using System.ComponentModel.DataAnnotations.Schema;

namespace intentory.Models
{
    [Table("ProductGroup", Schema = "public")]
    public class ProductGroup
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }
    }
}
