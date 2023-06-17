using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class ProductController : ControllerBase
    {
        public ProductController()
        {

        }

        [HttpGet("/api/products")]
        public ActionResult GetProductsAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet("/api/product/{id}")]
        public ActionResult GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("/api/product")]
        public ActionResult GetProductsWithCategory([FromQuery]string category) {
            throw new NotImplementedException();
        }

        [HttpPost("/api/product")]
        public ActionResult AddProduct([FromBody]AddProductCommand command)
        {
            throw new NotImplementedException();
        }

        [HttpPost("api/product/{id}/quantity")]
        public ActionResult ChangeProductQuantity(int id, [FromBody]int quantity)
        {
            throw new NotImplementedException();
        }

        [HttpPost("api/product/{id}/attribute")]
        public ActionResult AddAttribute(int id, [FromBody]AddAttributeCommand command)
        {
            throw new NotImplementedException();
        }

        [HttpPatch("api/product/{id}/attribute")]
        public ActionResult ChangeAttribute(int id, [FromBody]ChangeAttributeCommand command)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("api/product/{id}/attribute")]
        public ActionResult DeleteAttribute(int id, [FromBody]DeleteAttributeCommand command) { 
            throw new NotImplementedException();
        }

        [HttpDelete("api/product/{id}")]
        public ActionResult DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }
    }
}
