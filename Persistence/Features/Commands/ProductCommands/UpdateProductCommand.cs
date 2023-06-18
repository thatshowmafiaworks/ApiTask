using Domain.Entities;
using MediatR;

namespace Persistence.Features.Commands.ProductCommands
{
    public class UpdateProductCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category? Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public List<ProductAttribute>? Attributes { get; set; }

        public UpdateProductCommand(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Description = product.Description;
            Category = product.Category;
            Price = product.Price;
            Quantity = product.Quantity;
            Attributes = product.Attributes;
        }

    }
}
