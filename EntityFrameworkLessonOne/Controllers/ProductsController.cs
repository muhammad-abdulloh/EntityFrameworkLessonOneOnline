using EntityFrameworkLessonOne.DTOs;
using EntityFrameworkLessonOne.Serviecs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkLessonOne.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> InsertProduct(ProductDTO product)
        {
            var result = await _service.InsertProduct(product);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var result = await _service.GetAllProducts();

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int Id)
        {
            var result = await _service.DeleteProduct(Id);

            return Ok(result);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateProduct(int Id, ProductDTO productDTO)
        {
            var result = await _service.UpdateProduct(Id, productDTO);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetByIdMyProduct(int Id)
        {
            var result = await _service.GetByIdProduct(Id);

            return Ok(result);
        }

    }
}
