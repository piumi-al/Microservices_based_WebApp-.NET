/* IT19207964
 * Weerasooriya K.T.N.
 */
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryService.Data;
using DeliveryService.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeliveryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {

        private readonly IApplicationDbContext context;

        public DeliveryController(IApplicationDbContext context)
        {
            this.context = context;

        }

        // GET: api/<DeliveryController>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var deli = await this.context.Deliveries.ToListAsync();
            if (deli == null) return NotFound();
            return Ok(deli);
        }

        // GET api/<DeliveryController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var deli = await this.context.Deliveries.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (deli == null) return NotFound();
            return Ok(deli);
        }




        // POST api/<DeliveryController>
        [HttpPost]
        public async Task<IActionResult> Create(Delivery order)
        {
            this.context.Deliveries.Add(order);
            await this.context.SaveDeliveryChanges();
            return Ok("inserted successfully");
        }





        // PUT api/<DeliveryController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Delivery updatedetails)
        {
            var deli = this.context.Deliveries.Where(a => a.Id == id).FirstOrDefault();
            if (deli == null) return NotFound();
            else
            {
                deli.Delivery_Contact = updatedetails.Delivery_Contact;
                deli.Delivery_location = updatedetails.Delivery_location;
                await this.context.SaveDeliveryChanges();
                return Ok("updated successfully");
            }
        }



        // DELETE api/<DeliveryController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deli = await this.context.Deliveries.Where(a => a.Id == id).FirstOrDefaultAsync();
            if (deli == null) return NotFound();
            this.context.Deliveries.Remove(deli);
            await this.context.SaveDeliveryChanges();
            return Ok("Deleted successfully");
        }
    }
}
