using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.Api.Data;
using Shopping.Api.Models;

namespace Shopping.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private readonly ProductContext _productContext;

    public ProductController(ILogger<ProductController> logger, ProductContext productContext)
    {
        _logger = logger;
        _productContext = productContext;
    }

    [HttpGet]
    public async Task<IEnumerable<Product>> Get()
    {
        return await _productContext
            .Products
            .Find(prop => true)
            .ToListAsync();
    }
}
