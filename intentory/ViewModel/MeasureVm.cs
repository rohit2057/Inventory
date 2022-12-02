using intentory.Models;

namespace intentory.Models
{

    public class MeasureVm
    {
        public long? Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Code { get; set; }

        public List<Measure> measures { get; set; }

        public string? Status { get; set; }
    }
}
