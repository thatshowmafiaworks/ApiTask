using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persistence.DTOs;
using Persistence.Features.Commands.ProductCommands;
using Persistence.Features.Queries.CategoryQueries;
using Persistence.Features.Queries.ProductQueries;

namespace Api.Controllers
{
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/api/products")]
        public async Task<List<Product>> GetProductsAll()
        {
            var products = await _mediator.Send(new GetProductsListQuery());
            return products;
        }

        [HttpGet("/api/product/{id}")]
        public async Task<Product> GetProductById(int id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery { Id = id });
            return product;
        }

        [HttpGet("/api/product")]
        public async Task<List<Product>> GetProductsWithCategory([FromQuery] string category)
        {
            var categoryByName = await _mediator.Send(new GetCategoryByNameQuery { CategoryName = category });
            var products = await _mediator.Send(new GetProductsWithCategoryQuery { CategoryId = categoryByName.Id });
            return products;
        }

        [HttpPost("/api/product")]
        public async Task<Product> AddProduct([FromBody] ProductDTO productDTO)
        {
            var product = await _mediator.Send(new CreateProductCommand(productDTO));
            return product;
        }

        [HttpPost("api/product/{id}/quantity")]
        public async Task<int> ChangeProductQuantity(int id, [FromBody] int quantity)
        {
            var product = await _mediator.Send(new GetProductByIdQuery { Id = id });
            product.Quantity = quantity;
            var isUpdated = await _mediator.Send(new UpdateProductCommand(product));
            return isUpdated;
        }

        [HttpPost("api/product/{id}/attribute")]
        public ActionResult AddAttribute(int id, [FromBody] ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }

        [HttpPatch("api/product/{id}/attribute")]
        public ActionResult ChangeAttribute(int id, [FromBody] ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("api/product/{id}/attribute")]
        public ActionResult DeleteAttribute(int id, [FromBody] ProductDTO productDTO)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("api/product/{id}")]
        public async Task<int> DeleteProduct(int id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery { Id = id });
            var isDeleted = await _mediator.Send(new DeleteProductCommand { Id = id });
            return isDeleted;
        }
    }
}
