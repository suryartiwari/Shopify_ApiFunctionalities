using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoplifyApiFunctionalities.Models.Variants
{
    public class Product_SKU
    {
        public SKUVariant variant { get; set; }
    }

    public class SKUVariant
    {
        public long id { get; set; }
        public string sku { get; set; }
    }
}