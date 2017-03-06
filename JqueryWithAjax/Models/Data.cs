using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JqueryWithAjax.Models
{
    public class Data
    {
        private static List<Product> _products;
        public static List<Product> Products
        {
            get
            {
                if (_products == null)
                {
                    _products = new List<Product>
                    {
                        new Product
                        {
                            ID = 1, Name = "PC", Price = 1200
                        },
                        new Product
                        {
                            ID = 1, Name = "Notebook", Price = 2200
                        },
                        new Product
                        {
                            ID = 1, Name = "Tablet PC", Price = 3200
                        },
                        new Product
                        {
                            ID = 1, Name = "Netbook", Price = 4200
                        },
                        new Product
                        {
                            ID = 1, Name = "Ultrabook", Price = 5200
                        }
                    };
                }
                return _products;
            }
        }
    }
}