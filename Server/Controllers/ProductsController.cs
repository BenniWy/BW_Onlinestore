using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Shared.Models;

namespace Server.Controllers;
[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    private readonly AppDbContext _appDbContext;

    public ProductsController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    [HttpPost]
    public async Task<IActionResult> Create(Product productToCreate)
    {
        productToCreate.Id = Guid.NewGuid().ToString();

        await _appDbContext.AddAsync(productToCreate);

        await _appDbContext.SaveChangesAsync();

        return Ok(productToCreate);
    }

    [HttpGet]
    public async Task<IEnumerable<Product>> Get()
    {
        return await _appDbContext.Products.ToListAsync();
    }

    [HttpPut]
    public async Task<IActionResult> Update(Product updatedProduct)
    {
        if (updatedProduct == null)
        {
            return BadRequest("Product cannot be null.");
        }

        _appDbContext.Update(updatedProduct);

        await _appDbContext.SaveChangesAsync();

        return Ok(updatedProduct);
    }

    [HttpDelete]
    [Route("{productToDeleteId}")]
    public async Task<IActionResult> Delete(string productToDeleteId)
    {
        if (productToDeleteId == null)
        {
            return BadRequest("Product ID cannot be null.");
        }

        var productToDelete = await _appDbContext.Products.FindAsync(productToDeleteId);

        if (productToDelete == null)
        {
            return NotFound();
        }

        _appDbContext.Remove(productToDelete);

        await _appDbContext.SaveChangesAsync();

        return NoContent();
    }

}