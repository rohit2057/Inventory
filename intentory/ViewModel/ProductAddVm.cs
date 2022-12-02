using intentory.Models;

namespace intentory.Models
{

    public class ProductAddVm
    {
        public long? Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string UnitOfMeasure { get; set; }

        public List<ProductAdd> products { get; set; }

        public string? Status { get; set; }
    }
}
