using ClothingStore.Enum;

namespace ClothingStore.Model
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public CatalogArticle CatalogArticle { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public OrderTypeEnum OrderType { get; set; }
    }
}