using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DataModels;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Data;

namespace DataAccessLayer.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CollectorsKeepDbContext _context;

        public ProductRepository(CollectorsKeepDbContext context)
        {
            _context = context;
        }
        public List<Product> GetAll()
    => _context.Products.ToList();

        public Product? GetById(int id)
            => _context.Products.Find(id);

        public void Add(Product product)
            => _context.Products.Add(product);

        public void Update(Product product)
            => _context.Products.Update(product);

        public void Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
                _context.Products.Remove(product);
        }

        public void Save()
            => _context.SaveChanges();

    }
}
