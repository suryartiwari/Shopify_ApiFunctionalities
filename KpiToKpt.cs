using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoplifyApiFunctionalities.Models.Product
{
    public class KpiToKpt
    {
        public Variant4 variant { get; set; }
        public KpiToKpt()
        {

        }
        public KpiToKpt(Variant variant)
        {
            this.variant = new Variant4();
            this.variant.sku = variant.sku.Replace("Kpi","kpt").Replace("kpi","kpt");
        }
    }
    public class Variant4
    {
        public string sku { get; set; }
    }
}