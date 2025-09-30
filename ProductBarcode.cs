using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoplifyApiFunctionalities.Models.Variants
{
    public class ProductBarcode
    {
        public BarcodeVariant variant { get; set; }
    }
    public class BarcodeVariant
    {
        public long id { get; set; }
        public string barcode { get; set; }
       
    }
}