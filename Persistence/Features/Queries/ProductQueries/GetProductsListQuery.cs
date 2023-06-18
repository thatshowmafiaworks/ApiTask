using Domain.Entities;
using MediatR;

namespace Persistence.Features.Queries.ProductQueries
{
    public class GetProductsListQuery : IRequest<List<Product>>
    {

    }
}
