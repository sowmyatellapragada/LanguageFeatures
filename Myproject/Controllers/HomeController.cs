﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Myproject.Models;

namespace Myproject.Controllers
{
    public class HomeController : Controller
    {
        //bool FilterByPrice(Product p)
        //{
        //    return (p?.Price ?? 0) >= 20;
        //}
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public ViewResult Index()
        {
            // List<string> results = new List<string>();

            //foreach (Product p in Product.GetProducts())
            //{
            //    //string name = p?.Name ?? "<No Name>";
            //    //string category = p?.Category;
            //    //decimal? price = p?.Price ?? 0;
            //    //string relatedName = p?.Related?.Name ?? "< None > ";

            //    //results.Add($"Name: {name}, Category:{category},Price:{ price}, Related: { relatedName}");

            //        }
            // return View(results);
            //Dictionary<string, Product> products = new Dictionary<string, Product> 
            //{
            //    ["Kayak"] = new Product
            //    {
            //        Name = "Kayak",
            //        Price = 275M
            //    },
            //    ["Lifejacket"] = new Product
            //    {
            //        Name = "Lifejacket",
            //        Price = 48.95M
            //    }
            //};
            //return View("Index", products.Keys);

            //object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
            //decimal total = 0;

            //for (int i = 0; i < data.Length; i++)
            //{
            //    if (data[i] is decimal d)
            //    {
            //        total += d;
            //    }

            //}

            //for (int i = 0; i < data.Length; i++)
            //{
            //    switch (data[i])
            //    {
            //        case decimal decimalValue:
            //            total += decimalValue;
            //            break;
            //        case int intValue when intValue > 50:
            //            total += intValue;
            //            break;
            //    }
            //}

            // ShoppingCart cart = new ShoppingCart
            // {
            //Products= Product.GetProducts()
            // };
            //Product[] productArray = {new Product {Name = "Kayak", Price = 275M},new Product {Name = "Lifejacket", Price =48.95M},new Product {Name = "Soccer ball", Price =19.50M},new Product {Name = "Corner flag", Price =34.95M}};
            //decimal cartTotal = cart.TotalPrices();
            //decimal arrayTotal =productArray.FilterByPrice(20).TotalPrices();
            //return View("Index", new string[] { $"Total:{cartTotal:C2}", $"Array Total: {arrayTotal:C2}" });
            //decimal priceFilterTotal =productArray.FilterByPrice(20).TotalPrices();
            //decimal nameFilterTotal =productArray.FilterByName('S').TotalPrices();


            //Func<Product, bool> nameFilter = delegate(Product prod) {
            //    return prod?.Name?[0] == 'S';
            //     };

            //decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();
            //decimal nameFilterTotal = productArray.Filter(p => p?.Name?[0] == 'S').TotalPrices();
            //return View("Index", new string[] {$"Price Total: {priceFilterTotal:C2}",$"Name Total: {nameFilterTotal:C2}" });
            // return View(products.Select(p =>p.GetType().Name));


            IProductSelection cart = new ShoppingCart(new Product { Name = "Kayak", Price = 275M }, new Product{ Name = "Lifejacket",Price = 48.95M},new Product { Name = "Soccer ball", Price =19.50M},new Product{Name = "Corner flag",Price =34.95M});
            return View(cart.Names);
        }
    }
}

