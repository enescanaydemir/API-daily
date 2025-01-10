using ApiDaily.Data.Abstract;
using ApiDaily.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiDaily.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IGenericRepository<Product> _genericRepository;

        public ProductController(IGenericRepository<Product> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _genericRepository.GetAllAsync();
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            var newProduct = await _genericRepository.AddAsync(product);
            return Ok(newProduct);
        }
    }
}
