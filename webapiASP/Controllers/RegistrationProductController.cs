using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.EntityFrameworkCore;
using webapiASP.Models;

namespace webapiASP.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableRateLimiting("fixedWindow")]
    public class RegistrationProductController : ControllerBase
    {
        private DataContext _db;

        public RegistrationProductController(DataContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IAsyncEnumerable<RegistrationProduct> GetRegistrationProduct()
        {
            return _db.RegistrationProduct.AsAsyncEnumerable();
        }

        [HttpGet("{id}")]
        [DisableRateLimiting]
        public async Task<IActionResult> GetRegistrationProduct(long id)
        {
            RegistrationProduct? prices = await _db.RegistrationProduct.FindAsync(id);
            if (prices == null) return NotFound();
            return Ok(prices);
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync([FromBody] RegistrationProduct registrationProduct)
        {
            _db.RegistrationProduct.Add(registrationProduct);
            await _db.SaveChangesAsync();

            return Ok(registrationProduct);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(long id, [FromBody] RegistrationProduct registrationProduct)
        {
            var existingRegistrationProduct = await _db.RegistrationProduct.FindAsync(id);
            if (existingRegistrationProduct == null)
            {
                return NotFound(); 
            }

            try
            {
                existingRegistrationProduct.CreatedDate = registrationProduct.CreatedDate;
                existingRegistrationProduct.ProductName = registrationProduct.ProductName;
                existingRegistrationProduct.BuilderLastname = registrationProduct.BuilderLastname;
                existingRegistrationProduct.ProductCode = registrationProduct.ProductCode;
                existingRegistrationProduct.Quantity = registrationProduct.Quantity;
                existingRegistrationProduct.Price = registrationProduct.Price;
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Conflict(new { message = "The record was updated or deleted by another user." });
            }

            return Ok(existingRegistrationProduct);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(long id)
        {
            var registrationProduct = await _db.RegistrationProduct.FindAsync(id);
            if (registrationProduct == null) return NotFound();

            _db.RegistrationProduct.Remove(registrationProduct);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    }
}

