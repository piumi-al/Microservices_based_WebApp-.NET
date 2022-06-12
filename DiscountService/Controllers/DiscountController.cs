/* IT19209944
 * Aluvihare W.B.W.M.R.U.P.U.
 */
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscountService.Data;
using DiscountService.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiscountService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IApplicationDbContext context;

        public DiscountController(IApplicationDbContext context)
        {
            this.context = context;

        }

        // GET: api/<DiscountController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var discount = await this.context.Discounts.ToListAsync();
            if (discount == null) return NotFound();
            return Ok(discount);
        }




        // GET api/<DiscountController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var discount = await this.context.Discounts.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (discount == null) return NotFound();
            return Ok(discount);
        }




        // POST api/<DiscountController>
        [HttpPost]
        public async Task<IActionResult> Create(Discount discount)
        {
            this.context.Discounts.Add(discount);
            await this.context.SaveDiscountChanges();
            return Ok(discount.Id);
        }


        // PUT api/<DiscountController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Discount discountUpdate)
        {
            var discount = this.context.Discounts.Where(a => a.Id == id).FirstOrDefault();
            if (discount == null) return NotFound();
            else
            {
                discount.Discount_Type = discountUpdate.Discount_Type;
                discount.Discount_amount = discountUpdate.Discount_amount;
                discount.start_date = discountUpdate.start_date;
                discount.end_date = discountUpdate.end_date;
              
                await this.context.SaveDiscountChanges();
                return Ok(discount.Id);
            }
        }



        // DELETE api/<DiscountController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var discount = await this.context.Discounts.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (discount == null) return NotFound();
            this.context.Discounts.Remove(discount);
            await this.context.SaveDiscountChanges();
            return Ok(discount.Id);
        }



    }
}
