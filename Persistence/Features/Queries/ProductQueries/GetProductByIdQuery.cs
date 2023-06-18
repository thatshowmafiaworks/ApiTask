using Domain.Entities;
using MediatR;

namespace Persistence.Features.Queries.ProductQueries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }
    }
}
