using System.ComponentModel.DataAnnotations.Schema;

namespace intentory.Models
{
    [Table("Vendor", Schema = "public")]
    public class Vendor
    {
        public long? Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string? Status { get; set; }
    }
}
