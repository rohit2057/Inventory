using intentory.Models;

namespace intentory.Models
{

    public class CustomerVm
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Vendor> customers { get; set; }

        public string Status { get; set; }
    }
}
