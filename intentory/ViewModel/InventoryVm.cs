using intentory.Models;

namespace intentory.ViewModel
{
    public class InventoryVm
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string Measure { get; set; }

        public List<Inventory> inventories { get; set; }

        public string Status { get; set; }
    }
}
