using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POS_SYSTEM.Model;

namespace POS_SYSTEM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductListsController : ControllerBase
    {
        private readonly ProductContext _context;

        public ProductListsController(ProductContext context)
        {
            _context = context;
        }

        // GET: api/ProductLists
        [HttpGet]
        public IEnumerable<ProductList> GetProductLists()
        {
            return _context.ProductLists;
        }

        // GET: api/ProductLists/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productList = await _context.ProductLists.FindAsync(id);

            if (productList == null)
            {
                return NotFound();
            }

            return Ok(productList);
        }

        // PUT: api/ProductLists/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductList([FromRoute] int id, [FromBody] ProductList productList)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productList.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(productList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductListExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProductLists
        [HttpPost]
        public async Task<IActionResult> PostProductList([FromBody] ProductList productList)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(ModelState);
            }

            _context.ProductLists.Add(productList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductList", new { id = productList.ProductId }, productList);
        }

        // DELETE: api/ProductLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductList([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productList = await _context.ProductLists.FindAsync(id);
            if (productList == null)
            {
                return NotFound();
            }

            _context.ProductLists.Remove(productList);
            await _context.SaveChangesAsync();

            return Ok(productList);
        }

        private bool ProductListExists(int id)
        {
            return _context.ProductLists.Any(e => e.ProductId == id);
        }
    }
}