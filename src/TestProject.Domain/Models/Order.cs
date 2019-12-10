using System;
using System.Collections.Generic;

namespace TestProject.Domain.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public double Price { get; set; }

        public DateTime CreationDate { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
