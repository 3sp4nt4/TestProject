using System.Collections.Generic;
using TestProject.Domain.Models;

namespace TestProject.Domain.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();

        void Add(Order order);
    }
}
