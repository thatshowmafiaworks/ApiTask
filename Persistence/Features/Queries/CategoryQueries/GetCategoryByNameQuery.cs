using Domain.Entities;
using MediatR;

namespace Persistence.Features.Queries.CategoryQueries
{
    public class GetCategoryByNameQuery : IRequest<Category>
    {
        public string CategoryName { get; set; }
    }
}
