using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoplifyApiFunctionalities.Models.Product
{
    public class ProductStatus
    {
        public ProductSta product { get; set; }
        
    }
    public class ProductSta
    {
        public long id { get; set; }
        public string status { get; set; }
    }

    
}