using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myproject.Models
{
    public class ShoppingCart:IProductSelection

    {
        private List<Product> products = new List<Product>();

        public ShoppingCart(params Product[] prods)
        {
            products.AddRange(prods);
        }
        public IEnumerable<Product> Products {get =>products;}
        //        public IEnumerable<Product> Products using enumerbale
        //        {
        //            get; set;
        //        }
        //        public IEnumerator<Product> GetEnumerator() 
        //        {
        //            return Products.GetEnumerator();
        //        }
        //    IEnumerator IEnumerable.GetEnumerator()
        //  {
        //    return GetEnumerator();
        //}

    }
}
