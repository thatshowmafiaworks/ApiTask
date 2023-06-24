using Domain.Entities;

namespace Persistence.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        public Task<List<Category>> GetCategoriesListAsync();
        public Task<Category> GetCategoryByIdAsync(int Id);
        public Task<Category> AddCategoryAsync(Category category);
        public Task<int> UpdateCategoryAsync(Category category);
        public Task<int> DeleteCategoryAsync(int Id);
        public Task<Category> GetCategoryByNameAsync(string categoryName);
    }
}
