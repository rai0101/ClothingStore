using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Model
{
    public class ArticleDefinitionProperty
    {
        public int ArticleDefinitionPropertyId { get; set; }
        public PropertyType PropertyType { get; set; }
        public string PropertyValue { get; set; }        
    }
}
