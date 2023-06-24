using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Repositories.Interfaces;

namespace Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context) => _context = context;

        public async Task<List<Category>> GetCategoriesListAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int Id)
        {
            return await _context.Categories.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<Category> AddCategoryAsync(Category category)
        {
            var result = _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> UpdateCategoryAsync(Category category)
        {
            _context.Categories.Update(category);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteCategoryAsync(int Id)
        {
            var category = _context.Categories.Where(x => x.Id == Id).FirstOrDefault();
            _context.Categories.Remove(category);
            return await _context.SaveChangesAsync();
        }

        public async Task<Category> GetCategoryByNameAsync(string categoryName)
        {
            var category = await _context.Categories.Where(x => x.Name == categoryName).FirstOrDefaultAsync();
            return category;
        }
    }
}
