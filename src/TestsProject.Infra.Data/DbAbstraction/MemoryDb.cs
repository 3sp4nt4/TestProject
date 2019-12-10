using System;
using System.Collections.Generic;
using TestProject.Domain.Models;

namespace TestsProject.Infra.Data.DbAbstraction
{
    public static class MemoryDb
    {
        public static IList<Order> Orders { get; internal set; }
        public static IEnumerable<Product> Products { get; internal set; }

        public static void Init()
        {
            Orders = new List<Order>();
            Products = new List<Product>
            {
                new Product { Id = 1, Name = "Sandwich-1", Value = 10.20 },
                new Product { Id = 2, Name = "Sandwich-2", Value = 15.12 },
                new Product { Id = 3, Name = "Sandwich-3", Value = 20.18 }
            };
        }
    }
}
