using System.Collections.Generic;
using System.Linq;
using ClothingStore.Model;

namespace ClothingStore.Service
{
    public class OrderService : IService
    {
        public List<Supplier> GetListSupplier()
        {
            var listSupplier = new List<Supplier> {
                new Supplier
                {
                    SupplierID = 1,
                    SupplierName = "Supplier 1",
                    CatalogArticle = new List<CatalogArticle>
                    {
                        new CatalogArticle
                        {
                            CatalogArticleId = 1,
                            Quantity = 100,
                            CurrencyId = "USD",
                            Article = new Article
                            {
                               ArticleId = 1,
                               ArticleName = "T-Shirt A",
                               ArticleType = Enum.ArticleTypeEnum.TShirt,
                               BuyPrice = 6,
                               SellPrice = 12,
                               Size = 6,
                               Color = "red",
                               ArticleDefinition = new ArticleDefinition
                               {
                                   ArticleDefinitionId = 1,
                                   FriendlyName = "T-Shirt",
                                   ColorList = new List<Color>{
                                       new Color{ColorName = "red" },
                                       new Color{ColorName = "white" },
                                       new Color{ColorName = "yellow" }
                                   },
                                   SizeList = new List<int>{6,8,12},
                                   Properties = new List<ArticleDefinitionProperty>
                                   {
                                       //some property of Tshirt
                                       new ArticleDefinitionProperty
                                       {
                                           ArticleDefinitionPropertyId = 1,
                                           PropertyValue = "60% Cotton/40% Polyester",
                                           PropertyType = new PropertyType{
                                           Label ="Description"
                                           }
                                       }
                                   }
                               }
                            }
                        },
                         new CatalogArticle
                        {
                            CatalogArticleId = 2,
                            Quantity = 100,
                            CurrencyId = "USD",
                            Article = new Article
                            {
                               ArticleId = 2,
                               ArticleName = "Dress Shirt B",
                               ArticleType = Enum.ArticleTypeEnum.DressShirt,
                               BuyPrice = 8,
                               SellPrice = 20,
                               Size = 8,
                               Color = "white",
                               ArticleDefinition = new ArticleDefinition
                               {
                                   ArticleDefinitionId = 2,
                                   FriendlyName = "Dress Shirt",
                                   ColorList = new List<Color>{
                                       new Color{ColorName = "red" },
                                       new Color{ColorName = "white" },
                                       new Color{ColorName = "yellow" }
                                   },
                                   SizeList = new List<int>{6,8,12},
                                   Properties = new List<ArticleDefinitionProperty>
                                   {
                                       new ArticleDefinitionProperty
                                       {
                                           ArticleDefinitionPropertyId = 1,
                                           PropertyValue = "Machine Wash",
                                           PropertyType = new PropertyType{
                                           Label ="Description"
                                           }
                                       }
                                   }
                               }
                            }
                        }
                    }
                }};
            return listSupplier;
        }

        public Order MakeOrder(Supplier supplier)
        {
            var buyProduct = supplier.CatalogArticle.FirstOrDefault(x => x.Article.ArticleName == "T-Shirt A");
            var sellProduct = supplier.CatalogArticle.FirstOrDefault(x => x.Article.ArticleName == "Dress Shirt B");
            return new Order
            {
                CustomerId = 1,
                OrderId = 1,
                OrderNumber = "Order1",
                SupplierId = 1,
                Shipment = new Shipment
                {
                    Address = "473 Ho Chi Minh, Viet Nam",
                    Contact = "Vinh Vu",
                    ExpectedShipmentDate = new System.DateTime(2019, 4, 9),
                    Method = "By plane",
                    ShipmentId = 1
                },
                OrderItems = new List<OrderItem>
                {
                    new OrderItem {
                        OrderItemId = 1,
                        OrderType = Enum.OrderTypeEnum.Buy,
                        CatalogArticle = buyProduct,
                        Quantity = 10,
                        UnitPrice = buyProduct.Article.BuyPrice
                    },
                    new OrderItem {
                        OrderItemId = 2,
                        OrderType = Enum.OrderTypeEnum.Sell,
                        CatalogArticle = sellProduct,
                        Quantity = 20,
                        UnitPrice = buyProduct.Article.SellPrice
                    },
                }
            };
        }
    }
}
