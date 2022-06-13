/* IT19152110
 * Rajapaksha K.D.
 */
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartService.Data;
using CartService.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CartService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {

        private readonly IApplicationDbContext context;

        public CartController(IApplicationDbContext context)
        {
            this.context = context;

        }

        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cart = await this.context.Carts.ToListAsync();
            if (cart == null) return NotFound();
            return Ok(cart);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cart = await this.context.Carts.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (cart == null) return NotFound();
            return Ok(cart);
        }




        // POST api/<CustomerController>
        [HttpPost]
        public async Task<IActionResult> Create(Cart user)
        {
            this.context.Carts.Add(user);
            await this.context.SaveCartChanges();
            await this.context.SaveCartChanges();
            return Ok("insered successfully");
        }





       // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Cart qtyUpdate)
        {
            var cart = this.context.Carts.Where(a => a.Id == id).FirstOrDefault();
            if (cart == null) return NotFound();
            else
            {
                cart.Quantity = qtyUpdate.Quantity;
                await this.context.SaveCartChanges();
                return Ok("updated successfully");
            }
        }

  
        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var cart = await this.context.Carts.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (cart == null) return NotFound();
            this.context.Carts.Remove(cart);
            await this.context.SaveCartChanges();
            return Ok("Deleted sucessfully");
        }
    
    }
}
