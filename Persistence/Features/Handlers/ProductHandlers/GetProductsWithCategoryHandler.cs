using Domain.Entities;
using MediatR;
using Persistence.Features.Queries.ProductQueries;
using Persistence.Repositories.Interfaces;

namespace Persistence.Features.Handlers.ProductHandlers
{
    public class GetProductsWithCategoryHandler : IRequestHandler<GetProductsWithCategoryQuery, List<Product>>
    {
        private readonly IProductRepository _repository;

        public GetProductsWithCategoryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Product>> Handle(GetProductsWithCategoryQuery query, CancellationToken cancellationToken)
        {
            var products = await _repository.GetProductsWithCategoryAsync(query.CategoryId);
            return products;
        }
    }
}
