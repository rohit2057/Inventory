using intentory.Models;

namespace intentory.Models
{

    public class ProductGroupVm
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<ProductGroup> groups { get; set; }

        public string Status { get; set; }
    }
}
