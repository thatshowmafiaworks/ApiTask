using Domain.Entities;
using MediatR;
using Persistence.DTOs;

namespace Persistence.Features.Commands.ProductCommands
{
    public class CreateProductCommand : IRequest<Product>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Category? Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public IList<ProductAttribute>? Attributes { get; set; }

        public CreateProductCommand(ProductDTO productDTO)
        {
            Name = productDTO.Name;
            Description = productDTO.Description;
            Category = null;
            Price = productDTO.Price;
            Quantity = productDTO.Quantity;
            Attributes = null;
        }
    }
}
