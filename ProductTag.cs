using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoplifyApiFunctionalities.Models.Product
{
    public class ProductTag
    {
        public ProductTagRoot product { get; set; }
    }

    public class ProductTagRoot
    {
        public long id { get; set; }
        public string tags { get; set; }
    }
}