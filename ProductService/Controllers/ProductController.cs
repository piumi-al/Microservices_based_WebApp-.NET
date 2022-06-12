/* IT19209944
 * Aluvihare W.B.W.M.R.U.P.U.
 */
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductService.Data;
using ProductService.Entites;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IApplicationDbContext context;

        public ProductController(IApplicationDbContext context)
        {
            this.context = context;

        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var product = await this.context.Products.ToListAsync();
            if (product == null) return NotFound();
            return Ok(product);
        }



        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await this.context.Products.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (user == null) return NotFound();
            return Ok(user);
        }



        // POST api/<ProductController>
        [HttpPost]
        public async Task<IActionResult> Create(Product user)
        {
            this.context.Products.Add(user);
            await this.context.SaveProductChanges();
            return Ok(user.Id);
        }


        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Product userUpdate)
        {
            var product = this.context.Products.Where(a => a.Id == id).FirstOrDefault();
            if (product == null) return NotFound();
            else
            {
                product.Product_Name = userUpdate.Product_Name;
                product.Code = userUpdate.Code;
                product.Quantity_In_Stock = userUpdate.Quantity_In_Stock;
                product.Unit_Price = userUpdate.Unit_Price;
                await this.context.SaveProductChanges();
                return Ok(product.Id);
            }
        }



        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await this.context.Products.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (product == null) return NotFound();
            this.context.Products.Remove(product);
            await this.context.SaveProductChanges();
            return Ok(product.Id);
        }
        
    }
}


