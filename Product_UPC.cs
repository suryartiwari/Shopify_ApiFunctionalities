using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoplifyApiFunctionalities.Models.Product
{
    public class Product_UPC
    {
        public ProductUPCRoot Product { get; set; }
    }

    public class ProductUPCRoot
    {
        public long Id { get; set; }
        public string UPC { get; set; }
    }

}