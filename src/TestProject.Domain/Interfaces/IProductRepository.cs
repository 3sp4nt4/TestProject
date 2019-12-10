using System.Collections.Generic;
using TestProject.Domain.Models;

namespace TestProject.Domain.Interfaces
{
    public interface IProductRepository
    {
        Product GetById(int id);

        IEnumerable<Product> GetAll();
    }
}
