using MediatR;

namespace Persistence.Features.Commands.ProductCommands
{
    public class DeleteProductCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
