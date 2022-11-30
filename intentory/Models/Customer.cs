using System.ComponentModel.DataAnnotations.Schema;

namespace intentory.Models
{
    [Table("Customer", Schema = "public")]
    public class Customer
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }
    }
}
