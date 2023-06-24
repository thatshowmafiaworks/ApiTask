using Domain.Entities;
using MediatR;

namespace Persistence.Features.Queries.ProductQueries
{
    public class GetProductsWithCategoryQuery : IRequest<List<Product>>
    {
        public int CategoryId { get; set; }
    }
}
