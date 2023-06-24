using Domain.Entities;
using MediatR;
using Persistence.Features.Queries.CategoryQueries;
using Persistence.Repositories.Interfaces;

namespace Persistence.Features.Handlers.CategoryHandlers
{
    public class GetCategoryByNameHandler : IRequestHandler<GetCategoryByNameQuery, Category>
    {
        private readonly ICategoryRepository _repository;

        public GetCategoryByNameHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<Category> Handle(GetCategoryByNameQuery query, CancellationToken cancellationToken)
        {
            return await _repository.GetCategoryByNameAsync(query.CategoryName);
        }
    }
}
