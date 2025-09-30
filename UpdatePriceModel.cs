using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoplifyApiFunctionalities.Models
{
    public class UpdatePriceModel
    {
        public PriceVariant variant { get; set; } 

        public void variantObToPriceVariant(Variant varinatObj)
        {
            variant = new PriceVariant();
            if (String.IsNullOrEmpty(varinatObj.price))
            {
                variant.price = variant.compare_at_price;
            }
            else
            {
                variant.id = varinatObj.id;
                variant.price = varinatObj.price;
                variant.compare_at_price = varinatObj.compare_at_price;
                variant.cost = varinatObj.cost;
            }
        }
    }

    public class PriceVariant
    {
        public long id { get; set; }
        public string price { get; set; }
        public string compare_at_price { get; set; }
        public string cost { get; set; }
    }

}