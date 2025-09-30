using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoplifyApiFunctionalities.Models.Product
{
    public class Product_Inventory
    {
        public ProductRoot3 product { get; set; }
    }
    public class ProductRoot3
    {
        public long id { get; set; }
        public string inventory { get; set; }
    }
}