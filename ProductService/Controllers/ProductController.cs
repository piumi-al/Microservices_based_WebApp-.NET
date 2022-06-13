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
using ProductService.Entities;


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
            var product = await this.context.Products.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (product == null) return NotFound();
            return Ok(product);
        }



        // POST api/<ProductController>
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            this.context.Products.Add(product);
            await this.context.SaveProductChanges();
            return Ok("New product added sucessfully!");
            
        }

    



        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Product prUpdate)
        {
            var product = this.context.Products.Where(a => a.Id == id).FirstOrDefault();
            if (product == null) return NotFound();
            else
            {
                product.Product_Name = prUpdate.Product_Name;
                product.Code = prUpdate.Code;
                product.Quantity_In_Stock = prUpdate.Quantity_In_Stock;
                product.Unit_Price = prUpdate.Unit_Price;
                await this.context.SaveProductChanges();
                return Ok("updated sucessfully!!");
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
            return Ok("deleted sucessfully!!");
        }
        
    }
}


