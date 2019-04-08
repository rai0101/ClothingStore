using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Model
{
    public class ArticleDefinition
    {
        public int ArticleDefinitionId { get; set; }
       
        public string FriendlyName { get; set; }

        public List<ArticleDefinitionProperty> Properties { get; set; }

        public List<int> SizeList { get; set; }

        public List<Color> ColorList { get; set; }
    }
}
