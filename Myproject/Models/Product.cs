﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myproject.Models
{
    public class Product
    {
        public Product(bool stock = true)
        {
            InStock = stock;
        }
        public string Name { get; set; }
        public string Category { get; set; } 
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; } 
        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Category = "Water Craft",
                Price = 275M
            };
            Product lifejacket = new Product(false)
            {
                Name = "Lifejacket",
                Price = 48.95M
            };
            kayak.Related = lifejacket;
           
            return new Product[] { kayak, lifejacket,null};
        }

    }
}
