using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoplifyApiFunctionalities.Models.Product
{
    public class ProductStock
    {
        public ProductStockVariant variant { get; set; }
    }
    public class ProductStockVariant
    {
        public long id { get; set; }
        public string stock { get; set; }
    }
}