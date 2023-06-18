using Domain.Entities;

namespace Persistence.Repositories.Interfaces
{
    public interface IAttributeRepository
    {
        public Task<List<ProductAttribute>> GetAttributesListAsync();
        public Task<ProductAttribute> GetAttributeByIdAsync(int Id);
        public Task<ProductAttribute> AddAttributeAsync(ProductAttribute attribute);
        public Task<int> UpdateAttributeAsync(ProductAttribute attribute);
        public Task<int> DeleteAttributeAsync(int Id);
    }
}
