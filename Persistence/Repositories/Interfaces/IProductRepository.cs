using Domain.Entities;

namespace Persistence.Repositories.Interfaces
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetProductsListAsync();
        public Task<Product> GetProductByIdAsync(int Id);
        public Task<Product> AddProductAsync(Product product);
        public Task<int> UpdateProductAsync(Product product);
        public Task<int> DeleteProductAsync(int Id);
        public Task<List<Product>> GetProductsWithCategoryAsync(int categoryId);
    }
}
