using Domain.Entities;
using MediatR;
using Persistence.Features.Queries.ProductQueries;
using Persistence.Repositories.Interfaces;

namespace Persistence.Features.Handlers.ProductHandlers
{
    public class GetProductsListHandler : IRequestHandler<GetProductsListQuery, List<Product>>
    {
        private readonly IProductRepository _repository;

        public GetProductsListHandler(IProductRepository repository) => _repository = repository;

        public async Task<List<Product>> Handle(GetProductsListQuery query, CancellationToken cancellationToken)
        {
            return await _repository.GetProductsListAsync();
        }
    }
}
