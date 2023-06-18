using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Repositories.Interfaces;

namespace Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProductsListAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int Id)
        {
            return await _context.Products.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            var result = _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteProductAsync(int Id)
        {
            var product = _context.Products.Where(x => x.Id == Id).FirstOrDefault();
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }
    }
}
