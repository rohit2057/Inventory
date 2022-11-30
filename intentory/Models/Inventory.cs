
using System.ComponentModel.DataAnnotations.Schema;

namespace intentory.Models
{
    [Table("Inventory", Schema = "public")]
    public class Inventory
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        public string Writer { get; set; }

    }
}
