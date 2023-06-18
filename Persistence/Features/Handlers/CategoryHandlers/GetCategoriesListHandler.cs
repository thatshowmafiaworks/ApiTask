using Domain.Entities;
using MediatR;
using Persistence.Features.Queries.CategoryQueries;
using Persistence.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Features.Handlers.CategoryHandlers
{
    public class GetCategoriesListHandler : IRequestHandler<GetCategoriesListQuery, List<Category>>
    {
        private readonly ICategoryRepository _categoryRepository;
        public GetCategoriesListHandler(ICategoryRepository categoryRepository) => _categoryRepository = categoryRepository;

        public async Task<List<Category>> Handle(GetCategoriesListQuery request, CancellationToken cancellationToken)
            => await _categoryRepository.GetCategoriesListAsync();
    }
}
