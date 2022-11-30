﻿
using System.ComponentModel.DataAnnotations.Schema;

namespace intentory.Models
{
    [Table("Inventory", Schema = "public")]
    public class Inventory
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string Measure { get; set; }

        public string Status { get; set; }

    }
}
