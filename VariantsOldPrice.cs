using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ShoplifyApiFunctionalities.Models
{
    public class VariantsOldPrice
    {
        public List<Variant> variants { get; set; }

        public VariantsOldPrice DataTableToVariantPriceObj(DataTable table)
        {
            
            variants = new List<Variant>();
            foreach (DataRow row in table.Rows)
            {
                //compare_at_price = row[3].ToString(), price = row[1].ToString(),
                Variant variant = new Variant() { sku = row[0].ToString(), price = row[1].ToString(), cost = row[2].ToString(), };
                variants.Add(variant);
            }
            return this;
        }
        public VariantsOldPrice DataTableToVariantNullSpecialPriceObj(DataTable table)
        {
            
            variants = new List<Variant>();
            foreach (DataRow row in table.Rows)
            {
                // comment and uncomment according to sheet provided if price and cost both in sheet uncomment line no 32, if only price in sheet uncomment line no 31
                Variant variant = new Variant() { sku = row[0].ToString(), price = row[1].ToString(), cost = row[2].ToString() };
                //Variant variant = new Variant() {  sku = row[0].ToString(), price = row[1].ToString(), compare_at_price=null };
                variants.Add(variant);
            }
            return this;
        }
    }
    public class Variant
    {
        public long id { get; set; }
        public string price { get; set; }
        public string compare_at_price { get; set; }
        public string sku { get; set; }
        public string cost { get; set; }
    }
}




