using Domain.Entities;
using MediatR;
using Persistence.Features.Commands.ProductCommands;
using Persistence.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Features.Handlers.ProductHandlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly IProductRepository _repository;

        public CreateProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Product> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = command.Name,
                Description = command.Description,
                Category = command.Category,
                Price = command.Price,
                Quantity = command.Quantity,
                Attributes = command.Attributes
            };
            return await _repository.AddProductAsync(product);
        }
    }
}
