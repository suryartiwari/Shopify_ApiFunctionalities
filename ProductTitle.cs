using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoplifyApiFunctionalities.Models.Product
{

    public class ProductTitle
    {
        public ProductRoot product { get; set; }
    }
    public class ProductRoot
    {
        public long id { get; set; }
        public string title { get; set; }
    }
}