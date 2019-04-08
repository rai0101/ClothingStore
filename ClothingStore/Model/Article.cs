using ClothingStore.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Model
{
    public class Article
    {
        public int ArticleId { get; set; }

        public string ArticleName { get; set; }

        public string CurrencyId { get; set; }

        public ArticleTypeEnum ArticleType { get; set; }

        public decimal SellPrice { get; set; }

        public decimal BuyPrice { get; set; }

        public int Size  {get; set; }

        public string Color { get; set; }

        public ArticleDefinition ArticleDefinition { get; set; }
    }
}
