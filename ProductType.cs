using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoplifyApiFunctionalities.Models.Product
{
    public class ProductType
    {
        public ProductTypeRoot product { get; set; }
    }
    public class ProductTypeRoot
    {
        public long id { get; set; }
        public string product_type { get; set; }
    }
}