using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int SupplierId { get; set; }
        public int CustomerId { get; set; }
        public string OrderNumber { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public Shipment Shipment { get; set; }
    }
}
