using Domain.Entities;
using MediatR;
using Persistence.Features.Queries.ProductQueries;
using Persistence.Repositories.Interfaces;

namespace Persistence.Features.Handlers.ProductHandlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IProductRepository _repository;
        public GetProductByIdHandler(IProductRepository repository) => _repository = repository;

        public async Task<Product> Handle(GetProductByIdQuery query, CancellationToken cancellationToken)
        {
            return await _repository.GetProductByIdAsync(query.Id);
        }
    }
}
