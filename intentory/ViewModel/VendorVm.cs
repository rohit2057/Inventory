using intentory.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace intentory.Models
{

    public class VendorVm
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Vendor> vendors { get; set; }

        public string Status { get; set; }

        
    }
}
