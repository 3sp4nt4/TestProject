using System.Collections.Generic;
using System.Linq;
using TestProject.Domain.Interfaces;
using TestProject.Domain.Models;
using TestsProject.Infra.Data.DbAbstraction;

namespace TestsProject.Infra.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Product GetById(int id)
        {
            return MemoryDb.Products.FirstOrDefault(o => o.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return MemoryDb.Products;
        }
    }
}
