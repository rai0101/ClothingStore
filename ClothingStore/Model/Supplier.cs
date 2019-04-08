﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Model
{
    public class Supplier
    {
        public int SupplierID { get; set; }

        public string SupplierName { get; set; }

        public List<CatalogArticle> CatalogArticle { get; set; }
}
}
