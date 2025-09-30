using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoplifyApiFunctionalities.Models.Product
{
    public class Products
    {
        public List<Product> products { get; set; }
    }
    public class Image
    {
        public long id { get; set; }
    }

    public class Product
    {
        public long id { get; set; }
        public List<Variant1> variants { get; set; }
        public List<Image> images { get; set; }
    }

    public class MetafieldLists
    {
        public List<Metafields> metafields { get; set; }
    }
    public class Metafields
    {
        //public long metafield_id { get; set; }
        public long id { get; set; }
        public string @namespace { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public string type { get; set; }
        public long owner_id { get; set; }
        public string owner_resource { get; set; }
}

    public class Variant1
    {
        public long id { get; set; }
        public long product_id { get; set; }
        public string sku { get; set; }
        public long InventoryItemId { get; set; }

    }

    public class InventoryLevel
    {     
        public long LocationId { get; set; }      
        public long InventoryItemId { get; set; }  
        public string Available { get; set; }
    }

}