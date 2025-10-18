using ETicaretAPI.Application.Repositories.Customers;
using ETicaretAPI.Application.Repositories.Products;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductReadRepository _productReadRepository;
    private readonly IProductWriteRepository _productWriteRepository;
    private readonly IOrderWriteRepository _orderWriteRepository;
    public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository,IOrderWriteRepository orderWriteRepository)
    {
        _productReadRepository = productReadRepository;
        _productWriteRepository = productWriteRepository;
        _orderWriteRepository = orderWriteRepository;
    }

    [HttpGet]
    public async Task Get()
    {
        await _productWriteRepository.AddAsync(new() { Name = "C Product", Price = 1.500F, Stock = 10, CreatedDate = DateTime.UtcNow });
        await _productWriteRepository.SaveAsync();
    }



    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var product = await _productReadRepository.GetByIdAsync(id.ToString(), tracking: true);
        if (product == null) return NotFound();
        return Ok(product);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateProductDto dto)
    {
        if (dto == null) return BadRequest();

        var product = await _productReadRepository.GetByIdAsync(id.ToString(), tracking: false);
        if (product == null) return NotFound();

        // update alanları (örnek: sadece name)
        product.Name = dto.Name ?? product.Name;
        // product.Price = dto.Price ?? product.Price; // eğer diğer alanlar da varsa

        var savedCount = await _productWriteRepository.SaveAsync(); // int döner
        if (savedCount > 0)
            return Ok(new { message = "Updated", savedCount, product });
        else
            return StatusCode(500, new { message = "SaveFailed", savedCount });
    }
}

// DTO
public class UpdateProductDto
{
    public string? Name { get; set; }
    // diğer güncellenebilir alanlar eklenebilir (Price, Stock vb.)
}
