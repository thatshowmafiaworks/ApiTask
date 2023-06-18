using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Repositories.Interfaces;

namespace Persistence.Repositories
{
    public class AttributeRepository : IAttributeRepository
    {
        private readonly ApplicationDbContext _context;

        public AttributeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ProductAttribute> AddAttributeAsync(ProductAttribute attribute)
        {
            var result = _context.Attributes.Add(attribute);
            await _context.SaveChangesAsync();
            return attribute;
        }

        public async Task<int> DeleteAttributeAsync(int Id)
        {
            var attr = _context.Attributes.Where(x => x.Id == Id).FirstOrDefault();
            _context.Attributes.Remove(attr);
            return await _context.SaveChangesAsync();
        }

        public async Task<ProductAttribute> GetAttributeByIdAsync(int Id)
        {
            return await _context.Attributes.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<ProductAttribute>> GetAttributesListAsync()
        {
            return await _context.Attributes.ToListAsync();
        }

        public async Task<int> UpdateAttributeAsync(ProductAttribute attribute)
        {
            _context.Attributes.Update(attribute);
            return await _context.SaveChangesAsync();
        }
    }
}
