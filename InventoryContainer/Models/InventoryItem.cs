using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryContainer.Models
{
    public class InventoryItem
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public Decimal Price { get; set; }
        public int UnitsInStock { get; set; }
    }
}
