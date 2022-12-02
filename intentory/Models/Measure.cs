using System.ComponentModel.DataAnnotations.Schema;

namespace intentory.Models
{
    [Table("Measure", Schema = "public")]
    public class Measure
    {
        public long? Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Code { get; set; }

        public string? Status { get; set; }
    }
}
