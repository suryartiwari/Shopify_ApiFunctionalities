using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoplifyApiFunctionalities.Models.Product
{
    public class ProductDescription
    {
        public ProductRoot1 product { get; set; }
    }
    public class ProductRoot1
    {
        public long id { get; set; }
        public string body_html { get; set; }
    }
}