namespace ClothingStore.Model
{
    public class CatalogArticle
    {
        public int CatalogArticleId { get; set; }
        public Article Article { get; set; }
        public double Quantity { get; set; }
        public string CurrencyId { get; set; }
    }
}