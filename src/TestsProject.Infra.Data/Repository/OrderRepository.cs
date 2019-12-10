using System;
using System.Collections.Generic;
using TestProject.Domain.Interfaces;
using TestProject.Domain.Models;
using TestsProject.Infra.Data.DbAbstraction;

namespace TestsProject.Infra.Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void Add(Order order)
        {
            order.Id = Guid.NewGuid();
            order.CreationDate = DateTime.Now;

            MemoryDb.Orders.Add(order);
        }

        public IEnumerable<Order> GetAll()
        {
            return MemoryDb.Orders;
        }
    }
}
