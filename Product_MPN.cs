using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoplifyApiFunctionalities.Models.Product
{
    public class Product_MPN
    {
        public ProductRoot2 product { get; set; }
    }
    public class ProductRoot2
    {
        public long id { get; set; }
        public string MPN { get; set; }
    }
}