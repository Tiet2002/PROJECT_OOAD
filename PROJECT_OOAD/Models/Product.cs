using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_OOAD.Models
{
    public class Product
    {
        
            public int ID { get; set; }
            public string Name { get; set; }
            public string Price { get; set; }
            public string StockQuantity { get; set; }

            public Product(int P_ID, string Name, string Price, string StockQuantity)
            {
                this.ID = ID;
                this.Name = Name;
                this.Price = Price;
                this.StockQuantity = StockQuantity;
            }

        public Product() {
        
        }
    }
}