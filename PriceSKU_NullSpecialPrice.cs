using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoplifyApiFunctionalities.Models.Variants
{
    public class PriceSKU_NullSpecialPrice
    {
        public VariantPriceSKU_NullSpecialPrice variant { get; set; }
        public void variantObToPriceVariant(Variant varinatObj)
        {
            variant = new VariantPriceSKU_NullSpecialPrice();
            
                variant.id = varinatObj.id;
                variant.price = varinatObj.price;
            
        }
    }
    public class VariantPriceSKU_NullSpecialPrice
    {
        public long id { get; set; }
        public string price { get; set;}
        public object compare_at_price { get; set; } = null;
    }
}