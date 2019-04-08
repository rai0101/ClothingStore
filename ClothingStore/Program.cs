using ClothingStore.Model;
using ClothingStore.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore
{
    class Program
    {    /*
         Design model of this solution

         We have ArticleDefinition to define the cloth like Tshirt, DressShirt, Pant... : name, listSize, listColor (include image with color to display)
         Each ArticleDefiniton has list of ArticleDefinitionProperty to define its unique property. Example : shirt has some properties "60% Cotton/40% Polyester" , "Machine Wash"...
         Article is the instance of ArticleDefintion has sellPrice, buyPrice, color, size. Example Article "Calvin Klein T-Shirt is article of ArticleDefinition T-Shirt"

         Each supplier have a list of CatalogArticle to provide customer. CatalogArticle has quantity, currencyId, article.
         The customer after review list CatalogArticle from supplier they will buy or sell and make the order for each supplier. Each order has many order item.

         Otherwise each order has one shipment with shipmentDate, contact, shipmentType...
         */
        static void Main(string[] args)
        {
            IService _orderService = new OrderService();
            var supplier = _orderService.GetListSupplier();
            var order = _orderService.MakeOrder(supplier.First());
        }
    }
}





