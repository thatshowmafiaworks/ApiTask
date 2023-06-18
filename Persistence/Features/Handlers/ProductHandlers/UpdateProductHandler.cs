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
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, int>
    {
        private readonly IProductRepository _repository;
        public UpdateProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            var product = await _repository.GetProductByIdAsync(command.Id);
            product.Name = command.Name;
            product.Description = command.Description;
            product.Category = command.Category;
            product.Price = command.Price;
            product.Quantity = command.Quantity;
            product.Attributes = command.Attributes;
            return await _repository.UpdateProductAsync(product);
        }
    }
}
